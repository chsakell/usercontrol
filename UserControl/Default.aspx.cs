using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserControl.controls;

namespace UserControl
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> ActorFileUrls = GetActorFiles();
            BuildPageWithUserControls(ActorFileUrls);
        }

        private List<string> GetActorFiles()
        {
            List<string> files = new List<string>();
            string[] fileNames;
            string baseDirectory = MapPath("~/");
            fileNames = Directory.GetFiles(Path.Combine(baseDirectory, "content", "images"));
            foreach(string file in fileNames)
            {
                files.Add("~/content/images/" + Path.GetFileName(file));
            }
            return files;
        }

        private void BuildPageWithUserControls(List<string> fileUrls)
        {
            int numberOfActorsAdded = 0;

            // Set Active Actor
            string firstActorFile = fileUrls.First();
            ActiveActor activeActor = (ActiveActor)LoadControl("~/controls/ActiveActor.ascx");
            activeActor.SetImageUrl(firstActorFile);
            // Add actor to Actors PlaceHolder
            this.PlaceHolderActors.Controls.Add(activeActor);
            // Create a Page for this Actor
            PageTemplate firstActorsPage = (PageTemplate)LoadControl("~/controls/PageTemplate.ascx");
            firstActorsPage.SetActorName(Path.GetFileNameWithoutExtension(firstActorFile));
            firstActorsPage.SetPageNumber(numberOfActorsAdded.ToString());
            // Add it to Page PlaceHolder
            this.PlaceHolderPages.Controls.Add(firstActorsPage);
            numberOfActorsAdded++;
            fileUrls.Remove(firstActorFile);

            // Continue with other actors
            foreach (string actorFile in fileUrls)
            {
                NextActor nextActor = (NextActor)LoadControl("~/controls/NextActor.ascx");
                nextActor.SetImageUrl(actorFile);
                this.PlaceHolderActors.Controls.Add(nextActor);
                // Create a Page for this Actor
                PageTemplate nextActorsPage = (PageTemplate)LoadControl("~/controls/PageTemplate.ascx");
                nextActorsPage.SetActorName(Path.GetFileNameWithoutExtension(actorFile));
                nextActorsPage.SetPageNumber(numberOfActorsAdded.ToString());
                // Add it to Page PlaceHolder
                this.PlaceHolderPages.Controls.Add(nextActorsPage);
                numberOfActorsAdded++;
            }
        }
    }
}