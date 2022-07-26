namespace ObjectMaper
{
    internal interface IWizardConfiguration
    {
        string[] Descriptions { get; set; }
        bool OpenWizard { get; set; }
    }
}