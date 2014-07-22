# 数据库原理课程设计

本项目是同济大学软件学院2014年数据库原理课程设计的作业。

### 使用Git进行团队协作（超级精简版）

首先在[GitHub](http://github.com)注册一个账号，并把你的账户名告诉吴迪。接下来，[点击这里](http://git-scm.com/downloads)下载并安装git。如果是Mac系统，你的系统是有自带git的。

接下来，在命令提示符（Windows）或者Terminal（Linux/MacOS）下进入一个你日常放代码的目录，比如我把代码放在`/Code`文件夹，那我就首先进入它。

```bash
$ cd /Code
```

接下来，将项目文件全部拷贝到本地，通过下面的命令

```bash
$ git clone git@github.com:tjwudi/course_db.git
```

项目文件此时的位置是`/Code/course_db`。接下来，你可以对项目代码进行修改了。当你希望将你所编写的代码同步到服务器上时，执行下面的语句（每行一句）：

```bash
$ git add . -A
$ git commit -m "你的名字： 你所做的事情"
$ git push origin master
```

比如，当我完成了登陆界面，那么我就执行下面的语句

```bash
$ git add . -A
$ git commit -m "WuDi: Add login form"
$ git push origin master
```

如果你在执行最后一条`git push`语句时，出现类似`rejected`的信息。这是因为别人推了新的代码上去，你必须先把别人的代码同步下来，然后再一起同步上去。执行下面的语句可以将他人的代码同步下来

```bash
$ git pull origin master
```

如果在`git pull`的过程中遇到类似`Conflict`的提示，那么git会给出发生冲突的文件名。所谓冲突就是说，别人改了一个文件，你也改了那个文件，于是git不知道这个文件到底最终应该用哪个版本。打开git所告知的那些冲突的文件，将它们修改成你需要的样子，然后执行下面的语句。

```bash
$ git add . -A
$ git commit -m "merge"
$ git push origin master
```

这样，你就可以把你的工作同步到远程服务器了。

### 项目文件组织

- `READMD.md`：协作文档
- `src`文件夹：项目源代码
