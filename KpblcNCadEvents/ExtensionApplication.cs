using HostMgd.ApplicationServices;
using KpblcNCadEvents.Infrastructure;
using Teigha.Runtime;

namespace KpblcNCadEvents
{
    public class ExtensionApplication : IExtensionApplication
    {
        public void Initialize()
        {
            Application.DocumentManager.DocumentActivated += OnDocumentActivated;
            Application.DocumentManager.DocumentCreateStarted += OnDocumentStarted;
            Application.DocumentManager.DocumentBecameCurrent += OnDocumentBecameCurrent;
            Application.DocumentManager.DocumentCreated += OnDocumentCreated;
            Application.DocumentManager.DocumentDestroyed += OnDocumentDestroyed;
            Application.DocumentManager.CurrentDocument.CommandWillStart += OnCommandStart;
            Application.DocumentManager.CurrentDocument.CommandEnded += OnCommandEnd;
        }

        private void OnCommandEnd(object sender, CommandEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnCommandStart(object sender, CommandEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentDestroyed(object sender, DocumentDestroyedEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentCreated(object sender, DocumentCollectionEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentBecameCurrent(object sender, DocumentCollectionEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentStarted(object sender, DocumentCollectionEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentActivationChanged(object sender, DocumentActivationChangedEventArgs e)
        {
           Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        private void OnDocumentActivated(object sender, DocumentCollectionEventArgs e)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            LogService.LogMessage(doc == null ? null : doc.Name);
        }

        public void Terminate() { }
        
    }
}
