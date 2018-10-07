# FeatureToggleDemo

本实例Demo了如何通过使用Jason Roberts提供的开源框架FeatureToggle来实现.net core应用程序的功能开关。类库地址 - https://github.com/jason-roberts/FeatureToggle

## Demo1 – 随机开启或关闭功能

演示如何通过继承RandomFeatureToggle类，实现应用的随机开机或关闭， 例如这里小编实现了随机显示或隐藏当前程序中“微信通知”功能。


## Demo2 – 通过配置文件控制功能开启或关闭

演示如何通过配置文件来决定某个功能是否需要开启，这里可以通过继承SimpleFeatureToggle类加配置文件的方式实现功能的开启或关闭。
这里小编实现了配置“邮件通知”功能的显示或隐藏。

## Demo3 – 自定义功能开关

演示通过继承IFeatureToggle接口实现自定义的 ”开关”, 这里小编实现了“短信通知”功能只对特定用户开放。

