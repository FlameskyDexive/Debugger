# Debugger功能
1. 查看log信息，允许点击详情并复制到粘贴板，允许锁定log滚动面板
2. 支持开启log写入本地模式，可开启/关闭本地写log
3. 允许查看机器硬件信息（cpu/gpu/分辨率等等）
4. 允许查看profiler性能相关信息（内存详情，各种资源占用情况，允许截取示例查看）
5. 自适应多种屏幕分辨率
6. 增加搜索log功能

## Todo:
  - 打包成package集成到unity package manager中
  - 增加GM指令自定义关联

## 1.接入项目：
可以接入任意Unity项目，只需要checkout下来，把Debugger文件夹放到自己项目的插件目录即可。
## 2.使用步骤：
在MainCamera上添加Debugger脚本即可。

![image](https://user-images.githubusercontent.com/8274346/148244385-91906b19-94ff-4538-add1-60c98755776e.png)
![image](https://user-images.githubusercontent.com/8274346/148398514-19ddc758-e728-4f2e-875c-772e84fd17f6.png)
![image](https://user-images.githubusercontent.com/8274346/148398712-d8a77dc8-263f-4319-abb7-a528b4754380.png)
![image](https://user-images.githubusercontent.com/8274346/148244618-00c12fea-f1f7-4558-a83b-d2bde58a27d3.png)
![image](https://user-images.githubusercontent.com/8274346/148244858-bda8f94d-e6b7-44b5-97fa-4ebcdc5d3a45.png)
![5](https://user-images.githubusercontent.com/8274346/149524452-fd94b3bc-d136-4af7-a7d1-0803abaf03d3.png)
![6](https://user-images.githubusercontent.com/8274346/149524471-d0cc65b1-a53c-4a9d-ba68-6f9bbad80098.png)

## 说明
代码主要来源EllanJiang大佬的GameFramework框架的Debugger组件，原框架过于强大，调试相关代码耦合太多，本人抽离独立出来并针对自身需求做了修改，方便集成到个人项目中使用

GameFramework地址：https://github.com/EllanJiang/GameFramework
