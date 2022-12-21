namespace AdapterExample;
/// <summary>
/// Adaptador de Plug a un SmartDevice
/// </summary>
public class Adapter : ISmartDevice
{
    /// <summary>
    /// Constructor del adaptador
    /// </summary>
    /// <param name="plug"></param>
    public Adapter(Plug plug)
    {
        this.PlugAdapter = plug;
    }

    /// <summary>
    /// Plug adaptado
    /// </summary>
    public Plug PlugAdapter { get; set; }

    /// <summary>
    /// Para prender el dispositivo si esta apagado
    /// </summary>
    public void On()
    {
        if (PlugAdapter.GetStatus() == "off")
        {
            PlugAdapter.ToggleStatus();
        }
    }

    /// <summary>
    /// Para apagar el dispositivo si esta prendido
    /// </summary>
    public void Off()
    {
        if (PlugAdapter.GetStatus() == "on")
        {
            PlugAdapter.ToggleStatus();
        }
    }

    /// <summary>
    /// Devuelve el estado del dispositivo
    /// </summary>
    public string GetStatus()
    {
        return PlugAdapter.GetStatus();
    }
}