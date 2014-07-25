using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml;
using System.IO;

namespace DoubanAPI
{
    public static class ISBNChecker
    {
        public enum ISBN_ERROR
        {
            CORRECT,
            INVALID_LENGTH,
            NOT_NUMERIC,
            INVALID_CHECKCODE
        }

        public static ISBN_ERROR isValid(String isbn)
        {
            if (isbn == null || isbn.Length == 0) return ISBN_ERROR.INVALID_LENGTH;
            isbn = isbn.Replace("-", "");
            if (!Regex.IsMatch(isbn, "^\\d+$")) return ISBN_ERROR.NOT_NUMERIC; // ISBN必须为纯数字
            char lastCh = isbn[isbn.Length - 1];
            int sum;
            switch (isbn.Length)
            {
                case 10:
                    sum = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        sum += (11 - i) * ((int)isbn[i - 1] - '0');
                    }
                    sum = 11 - sum % 11;
                    switch (sum)
                    {
                        case 10:
                            if (lastCh == 'X' || lastCh == 'x') return ISBN_ERROR.CORRECT;
                            break;
                        case 11:
                            if (lastCh == '0') return ISBN_ERROR.CORRECT;
                            break;
                        default:
                            if (lastCh == sum + '0') return ISBN_ERROR.CORRECT;
                            break;
                    }
                    return ISBN_ERROR.INVALID_CHECKCODE;
                case 13:
                    sum = 0;
                    for (int i = 1; i <= 12; i++) sum += (((i & 1) == 1) ? 1 : 3) * ((int)isbn[i - 1] - '0');
                    sum = 10 - sum % 10;
                    if (sum == 10) sum = 0;
                    if (lastCh == sum + '0')
                        return ISBN_ERROR.CORRECT;
                    else
                        return ISBN_ERROR.INVALID_CHECKCODE;
            }
            return ISBN_ERROR.INVALID_LENGTH;

        }
    }

    public class BookQuery
    {
        static String QueryBookInfoURL = "http://api.douban.com/book/subject/isbn/{isbn}";

        private readonly String mISBN;
        private String mISBN10;

        public String MISBN10
        {
            get { return mISBN10; }
            set { mISBN10 = value; }
        }
        private String mISBN13;

        public String MISBN13
        {
            get { return mISBN13; }
            set { mISBN13 = value; }
        }
        private String mTitle;

        public String MTitle
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        private String mSummary;
        private String mPublisher;
        private String mAuthor;
        private List<String> mTags;
        private String mImageUrl;
        private int mPages;

        private BookQuery()
        {
        }

        public BookQuery(String isbn)
        {
            mISBN = isbn.Replace("-", "");
        }

        public enum BOOKQUERY_RESULT
        {
            SUCCESS,
            NETWORK_ERROR,
            PARSER_ERROR,
            NO_SUCH_BOOK,
            INVALID_ISBN,
            INTERNAL_ERROR
        }

        public BOOKQUERY_RESULT doQuery()
        {
            // 检查ISBN合法性
            if (ISBNChecker.isValid(mISBN) != ISBNChecker.ISBN_ERROR.CORRECT)
                return BOOKQUERY_RESULT.INVALID_ISBN;

            // 构建Request
            WebRequest request = null;
            try
            {
                request = HttpWebRequest.Create(new Uri(QueryBookInfoURL.Replace("{isbn}", mISBN)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BOOKQUERY_RESULT.INTERNAL_ERROR;
            }
            request.Method = "GET";
            request.Timeout = 5000; // 超时设为5秒

            WebResponse response = null;
            XmlDocument xml = null;
            try
            {
                // 获得Response
                response = request.GetResponse();
                // 准备解析XML
                xml = new XmlDocument();
                response = request.GetResponse();
                xml.Load(response.GetResponseStream());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BOOKQUERY_RESULT.NETWORK_ERROR;
            }
            Console.Write(xml.ToString());

            // 解析XML数据
            try
            {
                mTitle = xml.GetElementsByTagName("title").Item(0).FirstChild.InnerText;

                if (xml.GetElementsByTagName("summary").Item(0) != null)
                    mSummary = xml.GetElementsByTagName("summary").Item(0).FirstChild.InnerText;

                // 解析 db:attributes
                {
                    XmlNodeList dbattr = xml.GetElementsByTagName("db:attribute");
                    foreach (XmlNode node in dbattr)
                    {
                        String attrName = node.Attributes.GetNamedItem("name").FirstChild.InnerText;
                        String attrValue = node.FirstChild.InnerText;
                        switch (attrName)
                        {
                            case "isbn13":
                                mISBN13 = attrValue;
                                break;
                            case "isbn10":
                                mISBN10 = attrValue;
                                break;
                            case "pages":
                                mPages = int.Parse(attrValue);
                                break;
                            case "publisher":
                                mPublisher = attrValue;
                                break;
                            case "author":
                                mAuthor = attrValue;
                                break;
                        }
                    }
                }
                // 解析 db:tags
                {
                    XmlNodeList dbtag = xml.GetElementsByTagName("db:tag");
                    if (dbtag != null)
                    {
                        mTags = new List<String>();
                        foreach (XmlNode node in dbtag)
                        {
                            String tagName = node.Attributes.GetNamedItem("name").FirstChild.InnerText;
                            String tagCount = node.Attributes.GetNamedItem("count").FirstChild.InnerText;
                            mTags.Add(tagName);
                            //tag.setTagCount(Integer.parseInt(tagCount));
                        }
                    }
                }
                // 解析 link
                {
                    XmlNodeList links = xml.GetElementsByTagName("link");
                    foreach (XmlNode node in links)
                    {
                        // NodeName = link
                        String attrName = node.Attributes.GetNamedItem("rel").FirstChild.InnerText;
                        String attrValue = node.Attributes.GetNamedItem("href").FirstChild.InnerText;
                        switch (attrName)
                        {
                            case "image":
                                mImageUrl = attrValue;
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return BOOKQUERY_RESULT.PARSER_ERROR;
            }

            response.Close();
            return BOOKQUERY_RESULT.SUCCESS;
        }
    }
}
