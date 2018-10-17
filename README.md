# DocNet
简单的文档管理系统 
NET开源项目 QuarkDoc 一款自带极简主义属性的文档管理系统
有些话说在前头
因为公司产品业务重构且功能拆分组件化，往后会有很多的接口文档需要留存，所以急需一款文档管理系统。当时选型要求3点：
1.不能是云平台上的Saas服务，整个系统都要在自己公司部署维护（数据安全）
2..NET平台开发（利于维护）
3.开源（可按需重构） 

大约三周前，在线上找了很久开源的文档管理系统但都不尽人意。（showDoc很好，但可惜不是.NET平台的，自个在公司大约有7个测试服务器资源（都是Windows Server），虽然有物理机权限可以自己随意创建虚拟机资源，但是考虑未来维护最终舍弃了）
而团队大量文档需要整理留存，我个人也因低效的文档留存方式而被另外一个开发妹子问的心态快炸（总会被打断思路），痛定思痛，下定决心要开发一套文档管理系统拯救我即将变白的黑发。
遗留问题后续的迭代将会完善。
关于QuarkDoc
QuarkDoc是一个极简主义的文档管理系统。适用于团队或个人管理文档，提升团队沟通成本（本人未来的迭代路线也将以文档管理及开发常用辅助功能为主）。
目前（beta）包含模块：团队人员管理，项目管理，目录管理，文档管理，辅助功能。
人员管理：权限为管理员和非管理员两者，非管理员将无法使用团队人员管理模块。
项目管理：非管理人员不可使用此模块。
目录管理：目录结构为3层可任意配置。
辅助功能：
1.Json数据格式验证
2.JSON参数转Url
3.Http模拟请求
版权相关
QuarkDoc遵循BSD许可协议（最大诚意了）。
即：你可以自由获得、复制、修改、分发本原创软件作品(源码)；也可在源码基础上衍生你的软件作品。 衍生的软件作品(其源码)可以闭源而无需放置我的任何版权说明。但不可引用我的任何相关信息用于软件的版权声明或广告促销等。 注意：若使用QuarkDoc进行商业行为或衍生产品使用了本软件前端HTML部分请购买前端HTML正规许可（ https://www.creative-tim.com/product/material-dashboard-pro/?affiliate_id=101249）这个前端样式框架不是我写的的需要另外获取许可。

更新日志
QuarkDoc的维护更新及源码发布一定是在 http://www.cnblogs.com/jonins 其它任何平台（如：GitHub、开源中国、CSDN等）都非原作者。（密码太多真心记不住，简简单单挺好）
2018年9月4日　　beta

链接：https://pan.baidu.com/s/15VUkMNyJjsY9ATsEIzUt5Q 密码：fvps 解压码：cnblogs/jonins

QuarkDoc出生并开源

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
2.源码概括


3.示例QuarkDoc
       

作者：Jonins    出处：http://www.cnblogs.com/jonins/

本文版权归作者和博客园共有，欢迎转载，但未经作者同意必须保留此段声明，且在文章页面明显位置给出原文连接，否则保留追究法律责任的权利。
