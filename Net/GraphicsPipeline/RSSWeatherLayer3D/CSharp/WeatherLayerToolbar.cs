using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Runtime.InteropServices;
namespace RSSWeatherLayer3D
{

  [Guid("C01CE59C-5633-4a02-BD9D-46E1CFD8685F")]
  [ClassInterface(ClassInterfaceType.None)]
  [ProgId("RSSWeatherLayer3D.WeatherLayerToolbar")]
  [ComVisible(true)]
  public class WeatherLayerToolbar : IToolBarDef
  {
    #region COM Registration Function(s)
    [ComRegisterFunction()]
    [ComVisible(false)]
    static void RegisterFunction(Type registerType)
    {
      // Required for ArcGIS Component Category Registrar support
      ArcGISCategoryRegistration(registerType);

      //
      // TODO: Add any COM registration code here
      //
    }

    [ComUnregisterFunction()]
    [ComVisible(false)]
    static void UnregisterFunction(Type registerType)
    {
      // Required for ArcGIS Component Category Registrar support
      ArcGISCategoryUnregistration(registerType);

      //
      // TODO: Add any COM unregistration code here
      //
    }

    #region ArcGIS Component Category Registrar generated code
    /// <summary>
    /// Required method for ArcGIS Component Category registration -
    /// Do not modify the contents of this method with the code editor.
    /// </summary>
    private static void ArcGISCategoryRegistration(Type registerType)
    {
      string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
      GMxCommandBars.Register(regKey);
      ControlsToolbars.Register(regKey);
    }
    /// <summary>
    /// Required method for ArcGIS Component Category unregistration -
    /// Do not modify the contents of this method with the code editor.
    /// </summary>
    private static void ArcGISCategoryUnregistration(Type registerType)
    {
      string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
      GMxCommandBars.Unregister(regKey);
      ControlsToolbars.Unregister(regKey);
    }

    #endregion
    #endregion

    struct ToolDef
    {
      public string  itemDef;
      public bool    group;
      public ToolDef(string itd, bool grp)
      {
        itemDef = itd;
        group = grp;
      }
    };

    private ToolDef[] m_toolDefs = {
                                     new ToolDef("RSSWeatherLayer3D.AddWeatherLayerCmd", false),
                                     new ToolDef("RSSWeatherLayer3D.RefreshLayerCmd", false),
																		 new ToolDef("RSSWeatherLayer3D.AddWeatherItemTool", false),
																		 new ToolDef("RSSWeatherLayer3D.AddWeatherItemCmd", false),
                                     new ToolDef("RSSWeatherLayer3D.SelectItemsTool", false),
                                     new ToolDef("RSSWeatherLayer3D.SelectByCityNameCmd", false)
                                   };

    public WeatherLayerToolbar()
    {
    }

  
    #region IToolBarDef Implementations
    public void GetItemInfo(int pos, ESRI.ArcGIS.SystemUI.IItemDef itemDef)
    {
      itemDef.ID = m_toolDefs[pos].itemDef;
      itemDef.Group = m_toolDefs[pos].group;
    }

    public string Caption
    {
      get
      {
        return "Weather";
      }
    }

    public string Name
    {
      get
      {
        return "WeatherLayerToolbar";
      }
    }

    public int ItemCount
    {
      get
      {
        return m_toolDefs.Length;
      }
    }
    #endregion

  }
}