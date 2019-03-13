using AjustScreenBrightness.Abstract;
using AjustScreenBrightness.Model;
using igfxDHLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjustScreenBrightness
{
    /// <summary>
    /// 程序集添加引用 igfxDHLib.dll
    /// C:\Windows\System32\DriverStore\FileRepository\igdlh64.inf_amd64_neutral_3daeca3838e011e0\igfxDHLib.dll
    ///
    /// </summary>
    public class AjustScreenByIgfxDHLib : AjustScreenClass
    {
        public override string AjustTypeDes => "引用 igfxDHLib.dll";

        public override bool AllowBrightness => true;

        public override bool AllowContrast => true;

        public override bool AllowGamma => true;

        DataHandlerClass _cls = new DataHandlerClass();
        _CUI_COLOR_DEVICES _screenModel = default(_CUI_COLOR_DEVICES);

        public AjustScreenByIgfxDHLib()
        {

            CUI_SUPPORTED_CONFIG cui_SUPPORTED_CONFIG = default(CUI_SUPPORTED_CONFIG);
            uint num = _cls.get_SupportedConfig(ref cui_SUPPORTED_CONFIG);
            var id = cui_SUPPORTED_CONFIG.DeviceConfig[0].DispDev[0];
            uint[] array = new uint[3];
            var a = _cls.get_GetDeviceList(id, array);
            _screenModel.ulDevices = array[0];
            _screenModel.Device = new _CUI_COLOR_INFO[3];
            _screenModel.Device[0].Brightness.color = _COLOR_TYPE.NumColors;
            _screenModel.Device[0].Contrast.color = _COLOR_TYPE.NumColors;
            _screenModel.Device[0].Gamma.color = _COLOR_TYPE.NumColors;
            _screenModel.Command = _CUI_COLOR_COMMAND.GET_COLOR;
            _cls.get_color(_screenModel.ulDevices, ref _screenModel);

            _propRange.Brightness.Maximun = (int)_screenModel.Device[0].Brightness.values.fMax;
            _propRange.Brightness.Minimun = (int)_screenModel.Device[0].Brightness.values.fMin;
            _propRange.Contrast.Maximun = 80;//(int)_screenModel.Device[0].Contrast.values.fMax;
            _propRange.Contrast.Minimun = (int)_screenModel.Device[0].Contrast.values.fMin;
            _propRange.Gamma.Maximun = (int)_screenModel.Device[0].Gamma.values.fMax;
            _propRange.Gamma.Minimun = 0.4f;//(int)_screenModel.Device[0].Gamma.values.fMin;
        }

        public override short GetBrightnessDefault()
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.GET_COLOR;
            _cls.get_color(_screenModel.ulDevices, ref _screenModel);

            return (short)_screenModel.Device[0].Brightness.values.fCurrent;
        }

        public override short GetContrastDefault()
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.GET_COLOR;            
            _cls.get_color(_screenModel.ulDevices, ref _screenModel);
            return (short)_screenModel.Device[0].Contrast.values.fCurrent;
        }

        public override double GetGammaDefault()
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.GET_COLOR;            
            _cls.get_color(_screenModel.ulDevices, ref _screenModel);
            return (short)_screenModel.Device[0].Gamma.values.fCurrent;
        }

        public override ScreenConfig GetScreenConfigDefault()
        {
            throw new NotImplementedException();
        }

        public override bool SetBrightnessDefault(short val)
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.CHANGE_DEVICE_COLOR;
            _screenModel.Device[0].bApplyGamma = 1;
            _screenModel.Device[0].Brightness.values.fCurrent = val;
            _cls.set_color(_screenModel.ulDevices,ref _screenModel,0u);
            return true;
                
        }

        public override bool SetContrastDefault(short val)
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.CHANGE_DEVICE_COLOR;
            _screenModel.Device[0].bApplyGamma = 1;
            _screenModel.Device[0].Contrast.values.fCurrent = val;
            _cls.set_color(_screenModel.ulDevices, ref _screenModel, 0u);
            return true;
        }

        public override bool SetGammaDefault(double val)
        {
            _screenModel.Command = _CUI_COLOR_COMMAND.CHANGE_DEVICE_COLOR;
            _screenModel.Device[0].bApplyGamma = 1;
            _screenModel.Device[0].Gamma.values.fCurrent = (float)val;
            _cls.set_color(_screenModel.ulDevices, ref _screenModel, 0u);
            return true;
        }

        public override bool SetScreenConfigDefault(ScreenConfig config)
        {
            throw new NotImplementedException();
        }
    }
}
