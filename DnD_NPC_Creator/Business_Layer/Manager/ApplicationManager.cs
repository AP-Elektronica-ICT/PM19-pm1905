using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Manager
{
    class ApplicationManager
    {
        LoadManager LoadManager;
        SaveManager SaveManager;
        public ApplicationManager()
        {
            LoadManager = new LoadManager();
            SaveManager = new SaveManager();
        }
    }
}
