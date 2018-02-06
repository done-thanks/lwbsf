using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using GoC.WebTemplate;

namespace LWBSF_Ramp2.Controllers
{
    public class AppController : GoC.WebTemplate.WebTemplateBaseController
    {
        private void setFrench()
        {
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr.html", "Accueil", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement.html", "Environnement et ressources naturelles", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement/ressources-naturelles.html", "Ressources naturelles", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement/ressources-naturelles/eau.html", "Eau", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/environnement-changement-climatique/services/eau-apercu.html", "L'eau et l'environnement", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/environnement-changement-climatique/services/eau-apercu/assainissement-approche-globale.html", "L'assainissement de l'eau - une approche globale", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/environnement-changement-climatique/services/eau-apercu/assainissement-approche-globale/lac-winnipeg.html", "Assainissement du lac Winnipeg", ""));

            this.WebTemplateCore.HeaderTitle = "Fonds d'intendance du bassin du lac Winnipeg ";
            this.WebTemplateCore.ApplicationTitle.Text = "Fonds d'intendance du bassin du lac Winnipeg";
            this.WebTemplateCore.ContactLink = new Link("https://www.canada.ca/fr/contact.html", "Contact Us");
            this.WebTemplateCore.TermsConditionsLinkURL = "https://www.canada.ca/fr/transparence/avis.html";
            this.WebTemplateCore.PrivacyLinkURL = "https://www.canada.ca/fr/transparence/confidentialite.html";
        }

        private void setEnglish()
        {
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en.html", "Home", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment.html", "Environment and natural resources", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment/natural-resources.html", "Natural resources", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment/natural-resources/water.html", "Water", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/environment-climate-change/services/water-overview.html", "Water and the environment", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/environment-climate-change/services/water-overview/comprehensive-approach-clean.html", "Comprehensive approach to clean water", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/environment-climate-change/services/water-overview/comprehensive-approach-clean/lake-winnipeg.html", "Cleaning up Lake Winnipeg", ""));
            
            this.WebTemplateCore.HeaderTitle = "Lake Winnipeg Basin Stewardship Fund ";
            this.WebTemplateCore.ApplicationTitle.Text = "Lake Winnipeg Basin Stewardship Fund";
            this.WebTemplateCore.ContactLink = new Link("https://www.canada.ca/en/contact", "Contact Us");
            this.WebTemplateCore.TermsConditionsLinkURL = "https://www.canada.ca/en/transparency/terms.html";
            this.WebTemplateCore.PrivacyLinkURL = "https://www.canada.ca/en/transparency/privacy.html";
        }

        public ActionResult LWBSF_FIBLW(string lang)
        {
            if (this.WebTemplateCore.TwoLetterCultureLanguage == "fr")
            {
                setFrench();
            }
            else
            {
                setEnglish();
            }

            return View();
        }

        public ActionResult LWBSF()
        {
            return RedirectToAction("LWBSF_FIBLW");
        }
	}
}