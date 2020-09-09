# UGCFramework（Unity Game Client Framework）
unity-ILRuntime客户端框架(UGUI+C#+protocol+ILRuntime)

这是一个基于C＃语言的unity客户端框架，小部分工具基于UGUI，大部分工具不限制UI类型</p>
代码热更新方面使用的是ILRuntime热更技术</p>
通信采用socket+tcp方式，协议采用protocol buffer</p>

框架包括几个部分：</p>
  1、Bundle资源管理器（包括所有资源更新）</p>
  2、音频管理器</p>
  3、UI管理器</p>
  4、对象池管理器</p>
  5、第三方及原生sdk管理器（第三方登录、分享、支付，复制，电池电量等）</p>
  6、提示窗管理器</p>
  7、下载管理器</p>
  8、socket+ProtoBuf通信</p>
  9、组件式工具（动画、事件封装、定时器等）</p>
  10、实用性工具（图片处理、图片置灰、修改图片色相、文件下载、定位、文件和字符串加密等等）</p>
  11、UGUI扩展组件(Tab、RadioButton、计时器、动画、各种特殊图片组件等)</p>
  12、ILRuntime热更机制</p>

## v1.1.3更新日志 - 2020.9.9
  1、优化ScrollRect相关工具组件</p>
  2、优化渠道管理工具</p>
  3、优化部分ILRuntime相关适配器</p>
  4、修复部分跨平台编译问题</p>
  5、优化UI系统，简化UI结构，修改部分接口的调用方式，修复部分已知问题
  6、优化热更系统，简化热更注册执行方式
  7、优化CommonAnimation组件，修复在某些情况下Foward的改变会导致动画异常的问题
  7、修复示例脚本中的部分已知bug

## v1.1.2更新日志 - 2020.8.28
  1、调整所有脚本行尾设置</p>
  2、优化所有字段、属性的定义(本次修改了部分字段或属性的名称，请谨慎更新)</p>
  3、优化部分编辑器设定</p>
  4、优化了Scroll相关工具组件</p>
  
## v1.1.0更新日志 - 2020.8.13
  1、优化网络框架，优化在网络不稳定情况下的处理，优化网络重连逻辑</p>
  2、增加短链接请求，并实现长、短链接的混合使用
  3、更新UI框架，优化跳转流程</p>
  4、更新工具类，新增部分工具函数</p>
  5、优化通用动画工具，支持多组动画混合运行</p>
  6、优化原生相关逻辑，更新部分三方SDK，新增部分原生功能（苹果登录、本机号码一键登录等）</p>
  7、删除部分无用工具函数</p>
  8、优化框架文件结构，整合拆分示例代码和框架代码，移植更方便</p>
