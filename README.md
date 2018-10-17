# DocNet
简单的文档管理系统 

迭代计划：
1.代码删减，封装、并规范化（开发周期过短遗留下来的问题）。
2.图片上传。
3.附件上传。
4.模板留存。
5.历史版本。
6.权限（分项目、分读写）。

部署QuarkDoc
1.下载源码
2.发布Mins.QuarkDoc.Web
3.在SQL Server 2008及以上版本执行数据库创建脚本（Mins.QuarkDoc.Web项目DBScript文件夹下DBScript.sql文件）
4.修改Web.config文件下的数据库连接串
 <connectionStrings>
    <add name="DBContext" connectionString="Data Source=server;Initial Catalog=QuarkDoc;User ID=sa;password=password" providerName="System.Data.SqlClient" />
 </connectionStrings>
 
5.程序可以执行，初始登录权限（后续可以在人员管理进行修改）
账号：jonins@admin.com
密码：admin@admin

重构QuarkDoc
若认为QuarkDoc不错，想根据自己的需要更改需求，下面的内容或许能帮到你。
1.技术栈
前端：Vue + wangEditor + Bootstrap + Jquery.Validate + SweetAlert + Nouislider + Xss.js
后台：Asp.NET MVC + EntityFramework6 + Unity2.0 + Newtonsoft.Json + Nlog（本身是有的，DLL都拿过来了，但是在公司一周测试试用，并没有出现过问题，所以日志记录就暂时不加了）
设计思想：数据层采用仓储模式，业务层通过依赖注入继承基类的方式减少基础方法的直接实现，可使开发者更关注业务本身。因为本系统业务并不复杂，项目的逻辑压力根本没有到达逻辑层，大部分在控制器就已完成。

作者：Jonins    出处：http://www.cnblogs.com/jonins/
本文版权归作者和博客园共有，欢迎转载，但未经作者同意必须保留此段声明，且在文章页面明显位置给出原文连接，否则保留追究法律责任的权利。
