using System.Collections.Generic;
using System.Linq;

using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelper
{
    public class ObjectMappingControler
    {
        private ITransformContext context;
        IObjectProvider ObjectProvider { get; set; }
        public IReader Reader { get; set; }
        public iMaper Maper { get; set; }
        IParser Parser { get; set; }
        IWriter ConfigWriter { get; set; }
        IWriter ObjectWriter { get; set; }
        public IConfiguration configuration { get; set; }

        WizardPresenter Wizard;

        public ObjectMappingControler()
        {
            ITransformContext context = new TransformContext();
            Reader = context.Reader;
            Maper = context.Maper;
            Parser = context.Parser;
            ObjectProvider = context.ObjectProvider;
            Wizard = new WizardPresenter(context);
            ConfigWriter = context.Writer;
        }

        public ObjectMappingControler(ITransformContext context)
        {
            this.context = context;
            Reader = context.Reader;
            Maper = context.Maper;
            Parser = context.Parser;
            ObjectProvider = context.ObjectProvider;
            if (context.configuration.OpenWizard)
            {
                Wizard = new WizardPresenter(context);
            }
            ObjectWriter = context.Writer;              
        }

        public void GetInputData(IInputData data)
        {
            Parser.InputData = data;
        }
        public void GetObject<T>()
        {
            ObjectProvider.GetPropertiesFrom<T>();
        }

        public IEnumerable<T> GetMappedData<T>()
        {
            IEnumerable<T> dataReaded = Reader.GetRecords<T>();
            List<T> exportdata = new List<T>();

            //Jak jest gotowe mapowanie ustawione, to możemy to zrobić, jak nie to trzeba zrobić mapowanie
            if (Maper.Maps != null)
            {

                foreach (IObjectInfo oi in ObjectProvider.GetProperties().ToList())
                {
                    exportdata.Add(Maper.GetObject<T>(oi));
                }
            }
            return exportdata;
        }
    }
}
