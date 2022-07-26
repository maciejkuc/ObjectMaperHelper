using System;
using System.Collections.Generic;
using ObjectMaper.Interfaces;
using ObjectMaper.ViewModel;

namespace ObjectMaper
{
    class WizardPresenter : IWizard, IConfigWizard, IDataWizard
    {
        ParserViewModel ParserViewModel;
        MaperViewModel MaperViewModel;
        ReaderViewModel ReaderViewModel;

        public ITransformContext Context { get; }
        IWizardConfiguration Configuration { get; }

        IEnumerable<IObjectInfo> EnteredObjects;

        public WizardPresenter(ITransformContext context)
        {
            Context = context;
            ParserViewModel = new ParserViewModel(Context.Parser, context.configuration);
            MaperViewModel = new MaperViewModel(Context.Maper, context.configuration);
            ReaderViewModel = new ReaderViewModel(Context.Reader, context.configuration);

            Configuration = context.configuration;
            EnteredObjects = Context.ObjectProvider.GetProperties();
        }

        public IWizard GetWizard()
        {
            throw new NotImplementedException();
        }

        public void ShowControl()
        {

        }

        public string SaveConfig()
        {
            throw new NotImplementedException();
        }

        public string SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
