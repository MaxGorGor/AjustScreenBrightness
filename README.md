c# 多种方法调整屏幕亮度 
=====================
## 方法一: 使用网上常说的 Gdi32.dll 下的 SetDeviceGammaRamp (修改系统Gamma)
## 方法二: 使用MSDN上的 dxva2.dll SetMonitorBrightness
## 方法三: 使用 C:\Windows\System32\DriverStore\FileRepository\igdlh64.inf_amd64_neutral_3daeca3838e011e0\igfxDHLib.dll (这是驱动的文件,不同机器有自己对应的驱动文件)
`注意事项` 该方法使用时请注意好参数的范围,比如说把对比度设置太低时屏幕会完全黑掉 什么都看不到,然后你就不能直接把对比度调回来了.


