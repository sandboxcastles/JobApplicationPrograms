using CoverLetterTextMaker.Interfaces;
using Newtonsoft.Json;
using System.Data;

namespace CoverLetterTextMaker
{
    public partial class Form1 : Form
    {
        private PersonalInformation? PersonalInfo { get; set; }
        public Form1()
        {
            InitializeComponent();
            PersonalInfo = GetPersonalInfo();
        }

        private void generateTextBtn_Click(object sender, EventArgs e)
        {
            string generatedText = GetInjectedText();
            generatedTextTextBox.Text = generatedText;
            if (!string.IsNullOrWhiteSpace(generatedText))
            {
                createPdfBtn.Enabled = true;
            }
        }

        private void copyTextBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedTextTextBox.Text);
        }

        private void createPdfBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var converter = new ConvertTextToPdf.Converter();
                    converter.ConvertToPdf(generatedTextTextBox.Text, fbd.SelectedPath, $"{PersonalInfo?.FirstName ?? "My"}_{PersonalInfo?.LastName ?? "Personal"}_Cover_Letter-{companyNameTextBox.Text}_({jobNameTextBox.Text.Replace(" ", "_")})");
                }
            }
        }

        private PersonalInformation? GetPersonalInfo()
        {
            using (var sr = new StreamReader("personal-info.json"))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<PersonalInformation>(json);
            }
        }

        private string GetPersonalLocationText(PersonalInformation info)
        {
            var zip = !string.IsNullOrWhiteSpace(info.Zip) ? $" {info.Zip}" : string.Empty;
            if (!string.IsNullOrWhiteSpace(info.City) && !string.IsNullOrWhiteSpace(info.StateCode))
            {
                return $"{info.City}, {info.StateCode}{zip}";
            }
            return $"{info.City ?? string.Empty}{info.StateCode ?? string.Empty}{zip}".Trim();
        }

        private string GetKeywordsText(IEnumerable<string> keywords)
        {
            int keywordCount = keywords.Count();
            if (string.IsNullOrEmpty(PersonalInfo?.JobSpecificQualificationsText) || keywordCount == 0) {
                return string.Empty;
            }

            string parsedKeywords = string.Empty;
            switch (keywordCount)
            {
                case 1:
                    {
                        parsedKeywords = keywords.First();
                        break;
                    }
                case 2:
                    {
                        parsedKeywords = string.Join(" and ", keywords);
                        break;
                    }
                default:
                    {
                        parsedKeywords = string.Join(", ", keywords.Select((word, index) => index < keywordCount - 1 ? word : $"and {word}"));
                        break;
                    }
            }
            // Maybe put this in the 'GetInjectedText' function
            return $" {PersonalInfo.JobSpecificQualificationsText.Replace("{keywords}", parsedKeywords)}";
        }

        private string GetInjectedText()
        {
            if (PersonalInfo == null)
            {
                return string.Empty;
            }

            string jobSpecificKeywordsText = GetJobSpecificKeywordsText();
            string jobListingLocationText = GetJobListingLocationText();
            string body = GetBody();

            return body
                .Replace("{role}", jobNameTextBox.Text)
                .Replace("{companyName}", companyNameTextBox.Text)
                .Replace("{experienceIn}", experienceInTextBox.Text)
                .Replace("{jobSpecificQualifications}", jobSpecificKeywordsText)
                .Replace("{jobListingLocation}", jobListingLocationText)
                .Replace("{firstName}", PersonalInfo.FirstName ?? string.Empty)
                .Replace("{lastName}", PersonalInfo.LastName ?? string.Empty)
                .Replace("{phone}", PersonalInfo.PhoneNumber ?? string.Empty)
                .Replace("{city}", PersonalInfo.City ?? string.Empty)
                .Replace("{stateCode}", PersonalInfo.StateCode ?? string.Empty)
                .Replace("{zip}", PersonalInfo.Zip ?? string.Empty);
        }

        private string GetJobSpecificKeywordsText()
        {
            string jobSpecificQualifications = jobSpecificQualificationsTextBox.Text;
            var keywords = jobSpecificQualifications?
                .Split(",")
                .Select(w => w.Trim())
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .ToList() ?? new List<string>();

            return GetKeywordsText(keywords);
        }

        private string GetJobListingLocationText()
        {
            string jobListingLocation = jobListingLocationTextBox.Text ?? string.Empty;
            return !string.IsNullOrWhiteSpace(jobListingLocation) ? $" {jobListingLocation}" : string.Empty;
        }

        private string GetBody()
        {
            if (PersonalInfo == null)
            {
                return string.Empty;
            }
            var heading = PersonalInfo.Heading ?? string.Empty;
            var filteredParagraphs = string.Join("\r\n\r\n",
                PersonalInfo.Paragraphs?
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrWhiteSpace(p)) ?? new List<string>()
                )
                ?? string.Empty;

            var signOff = PersonalInfo.SignOff ?? "Thank you,";

            var nameLine = $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
            var locationText = GetPersonalLocationText(PersonalInfo);

            var personalInfoTextLines = new List<string>
            {
                nameLine,
                PersonalInfo?.Email ?? string.Empty,
                PersonalInfo?.PhoneNumber ?? string.Empty,
                locationText
            }
            .Select(l => l.Trim())
            .Where(text => !string.IsNullOrWhiteSpace(text));

            var personalInfoText = personalInfoTextLines.Count() > 0 ? string.Join("\r\n", personalInfoTextLines) : string.Empty;

            var bodySections = new List<string>
            {
                heading,
                filteredParagraphs,
                signOff,
                personalInfoText
            };
            return string.Join("\r\n\r\n", bodySections);
        }
    }
}
