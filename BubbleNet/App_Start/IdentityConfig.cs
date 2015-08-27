using BubbleNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BubbleNet.App_Start
{
    public class ApplicationDbInitializer
        : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            InitializeIdentityForEF(context);
            base.Seed(context);
        }

        public static void InitializeIdentityForEF(ApplicationDbContext context)
        {
            CreateCountries(context);
        }



        private static void CreateCountries(ApplicationDbContext context)
        {
            context.Countries.Add(new Country() { Code = "AFG", Name = "Afghanistan", TimeZone = "UTC+04:30", UtcOffset = 4.50f });
            context.Countries.Add(new Country() { Code = "ALB", Name = "Albania", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "DZA", Name = "Algeria", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "AND", Name = "Andorra", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "AGO", Name = "Angola", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "ARG", Name = "Argentina", TimeZone = "UTC−03:00 (ART)", UtcOffset = -3.0f });
            context.Countries.Add(new Country() { Code = "ARM", Name = "Armenia", TimeZone = "UTC+04:00", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "AUS", Name = "Australia", TimeZone = "UTC+10:00 (AEST)", UtcOffset = 10.0f });
            context.Countries.Add(new Country() { Code = "AUT", Name = "Austria", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "AZE", Name = "Azerbaijan", TimeZone = "UTC+04:00 (Azerbaijan)", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "BHR", Name = "Bahrain", TimeZone = "UTC+03:00 (Bahrain)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "BGD", Name = "Bangladesh", TimeZone = "UTC+06:00 (BDT)", UtcOffset = 6.0f });
            context.Countries.Add(new Country() { Code = "BLR", Name = "Belarus", TimeZone = "UTC+03:00 (FET)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "BEL", Name = "Belgium", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "BEN", Name = "Benin", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "BTN", Name = "Bhutan", TimeZone = "UTC+06:00 (BTT)", UtcOffset = 6.0f });
            context.Countries.Add(new Country() { Code = "BOL", Name = "Bolivia", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "BIH", Name = "Bosnia and Herzegovina", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "BWA", Name = "Botswana", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "BRA", Name = "Brazil", TimeZone = "UTC−03:00", UtcOffset = -3.0f });
            context.Countries.Add(new Country() { Code = "BRN", Name = "Brunei Darussalam", TimeZone = "UTC+08:00", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "BGR", Name = "Bulgaria", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "KHM", Name = "Cambodia", TimeZone = "UTC+07:00", UtcOffset = 7.0f });
            context.Countries.Add(new Country() { Code = "CMR", Name = "Cameroon", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "CAN", Name = "Canada", TimeZone = "UTC−06:00 (CST)", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "CPV", Name = "Cape Verde", TimeZone = "UTC−01:00 (Cape Verde Time)", UtcOffset = -1.0f });
            context.Countries.Add(new Country() { Code = "CAF", Name = "Central African Republic", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "TCD", Name = "Chad", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "CHL", Name = "Chile", TimeZone = "UTC−03:00 ", UtcOffset = -3.0f });
            context.Countries.Add(new Country() { Code = "CHN", Name = "China", TimeZone = "UTC+08:00 (Chinese Standard Time)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "COL", Name = "Colombia", TimeZone = "UTC−05:00 (Colombia)", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "COM", Name = "Comoros", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "COD", Name = "Congo, the Democratic Republic of the", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "CRI", Name = "Costa Rica", TimeZone = "UTC−06:00 (Costa Rica)", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "HRV", Name = "Croatia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "CUB", Name = "Cuba", TimeZone = "UTC−05:00 (Cuba)", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "CYP", Name = "Cyprus", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "CZE", Name = "Czech Republic", TimeZone = "UTC+01:00 (CET) (CRT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "DNK", Name = "Denmark", TimeZone = "UTC+01:00 (Denmark)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "DJI", Name = "Djibouti", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "DMA", Name = "Dominica", TimeZone = "UTC−04:00(Dominica)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "DOM", Name = "Dominican Republic", TimeZone = "UTC−04:00 (Dominican Republic)", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "ECU", Name = "Ecuador", TimeZone = "UTC−05:00 (Ecuador Time)", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "EGY", Name = "Egypt", TimeZone = "UTC+02:00 (EST)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "SLV", Name = "El Salvador", TimeZone = "UTC−06:00", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "GNQ", Name = "Equatorial Guinea", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "ERI", Name = "Eritrea", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "EST", Name = "Estonia", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "ETH", Name = "Ethiopia", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "FJI", Name = "Fiji", TimeZone = "UTC+12:00 (Fiji)", UtcOffset = 12.0f });
            context.Countries.Add(new Country() { Code = "FIN", Name = "Finland", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "FRA", Name = "France", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "GAB", Name = "Gabon", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "GMB", Name = "Gambia", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "GEO", Name = "Georgia", TimeZone = "UTC+04:00", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "DEU", Name = "Germany", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "GHA", Name = "Ghana", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "GRC", Name = "Greece", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "GRD", Name = "Grenada", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "GTM", Name = "Guatemala", TimeZone = "UTC−06:00", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "GIN", Name = "Guinea", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "GNB", Name = "Guinea-Bissau", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "GUY", Name = "Guyana", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "HTI", Name = "Haiti", TimeZone = "UTC−05:00", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "HND", Name = "Honduras", TimeZone = "UTC−06:00", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "HKG", Name = "Hong Kong", TimeZone = "UTC+08:00 (HKT)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "HUN", Name = "Hungary", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "ISL", Name = "Iceland", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "IND", Name = "India", TimeZone = "UTC+05:30 (IST)", UtcOffset = 5.50f });
            context.Countries.Add(new Country() { Code = "IDN", Name = "Indonesia", TimeZone = "UTC+08:00", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "IRN", Name = "Iran, Islamic Republic of", TimeZone = "UTC+03:30 (IRST)", UtcOffset = 2.50f });
            context.Countries.Add(new Country() { Code = "IRQ", Name = "Iraq", TimeZone = "UTC+03:00", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "IRL", Name = "Ireland", TimeZone = "UTC (WET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "ISR", Name = "Israel", TimeZone = "UTC+02:00 (IST)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "ITA", Name = "Italy", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "JAM", Name = "Jamaica", TimeZone = "UTC−05:00", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "JPN", Name = "Japan", TimeZone = "UTC+09:00 (JST)", UtcOffset = 9.0f });
            context.Countries.Add(new Country() { Code = "JOR", Name = "Jordan", TimeZone = "UTC+02:00", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "KEN", Name = "Kenya", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "PRK", Name = "Korea, Democratic People's Republic of", TimeZone = "UTC+08:30 (Pyongyang Time)", UtcOffset = 8.5f });
            context.Countries.Add(new Country() { Code = "KOR", Name = "Korea, Republic of", TimeZone = "UTC+09:00 (Korea Standard Time)", UtcOffset = 9.0f });
            context.Countries.Add(new Country() { Code = "KWT", Name = "Kuwait", TimeZone = "UTC+03:00 (Arabia Standard Time)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "KGZ", Name = "Kyrgyzstan", TimeZone = "UTC+06:00 (Kyrgyzstan)", UtcOffset = 6.0f });
            context.Countries.Add(new Country() { Code = "LAO", Name = "Laos", TimeZone = "UTC+07:00 (Laos)", UtcOffset = 7.0f });
            context.Countries.Add(new Country() { Code = "LVA", Name = "Latvia", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "LBN", Name = "Lebanon", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "LSO", Name = "Lesotho", TimeZone = "UTC+02:00 (Lesotho)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "LBR", Name = "Liberia", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "LBY", Name = "Libya", TimeZone = "UTC+02:00 (Libya)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "LIE", Name = "Liechtenstein", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "LTU", Name = "Lithuania", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "LUX", Name = "Luxembourg", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MAC", Name = "Macao", TimeZone = "UTC+08:00 (Macau Standard Time)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "MKD", Name = "Macedonia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MDG", Name = "Madagascar", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "MWI", Name = "Malawi", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "MYS", Name = "Malaysia", TimeZone = "UTC+08:00 (Malaysian Standard Time)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "MDV", Name = "Maldives", TimeZone = "UTC+05:00", UtcOffset = 5.0f });
            context.Countries.Add(new Country() { Code = "MLI", Name = "Mali", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "MLT", Name = "Malta", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MHL", Name = "Marshall Islands", TimeZone = "UTC+12:00", UtcOffset = 12.0f });
            context.Countries.Add(new Country() { Code = "MRT", Name = "Mauritania", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "MUS", Name = "Mauritius", TimeZone = "UTC+04:00 (Mauritius Time)", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "MEX", Name = "Mexico", TimeZone = "UTC−06:00 (Mexico)", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "MDA", Name = "Moldova, Republic of", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "MCO", Name = "Monaco", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MNG", Name = "Mongolia", TimeZone = "UTC+08:00", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "MNE", Name = "Montenegro", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MAR", Name = "Morocco", TimeZone = "UTC (WET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "MOZ", Name = "Mozambique", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "MMR", Name = "Myanmar", TimeZone = "UTC+06:30 (MST)", UtcOffset = 6.0f });
            context.Countries.Add(new Country() { Code = "NAM", Name = "Namibia", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "NRU", Name = "Nauru", TimeZone = "UTC+12:00 (Nauru)", UtcOffset = 12.0f });
            context.Countries.Add(new Country() { Code = "NPL", Name = "Nepal", TimeZone = "UTC+05:45 (Nepal Time)", UtcOffset = 5.74f });
            context.Countries.Add(new Country() { Code = "NLD", Name = "Netherlands", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "NZL", Name = "New Zealand", TimeZone = "UTC+12:00", UtcOffset = 12.0f });
            context.Countries.Add(new Country() { Code = "NIC", Name = "Nicaragua", TimeZone = "UTC−06:00 (Nicaragua)", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "NER", Name = "Niger", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "NGA", Name = "Nigeria", TimeZone = "UTC+01:00 (WAT)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "NOR", Name = "Norway", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "OMN", Name = "Oman", TimeZone = "UTC+04:00", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "PAK", Name = "Pakistan", TimeZone = "UTC+05:00 (PKT)", UtcOffset = 5.0f });
            context.Countries.Add(new Country() { Code = "PLW", Name = "Palau", TimeZone = "UTC+09:00", UtcOffset = 9.0f });
            context.Countries.Add(new Country() { Code = "PAN", Name = "Panama", TimeZone = "UTC−05:00", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "PNG", Name = "Papua New Guinea", TimeZone = "UTC+10:00", UtcOffset = 10.0f });
            context.Countries.Add(new Country() { Code = "PRY", Name = "Paraguay", TimeZone = "UTC−04:00", UtcOffset = -.0f });
            context.Countries.Add(new Country() { Code = "PER", Name = "Peru", TimeZone = "UTC−05:00 (PET)", UtcOffset = -5.0f });
            context.Countries.Add(new Country() { Code = "PHL", Name = "Philippines", TimeZone = "UTC+08:00 (PHT)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "POL", Name = "Poland", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "PRT", Name = "Portugal", TimeZone = "UTC (WET) ", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "QAT", Name = "Qatar", TimeZone = "UTC+03:00 (Arabia Standard Time)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "ROU", Name = "Romania", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "RWA", Name = "Rwanda", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "KNA", Name = "Saint Kitts and Nevis", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "LCA", Name = "Saint Lucia", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "VCT", Name = "Saint Vincent and the Grenadines", TimeZone = "UTC−04:00", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "WSM", Name = "Samoa", TimeZone = "UTC+13:00", UtcOffset = 13.0f });
            context.Countries.Add(new Country() { Code = "SMR", Name = "San Marino", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "STP", Name = "Sao Tome and Principe", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "SAU", Name = "Saudi Arabia", TimeZone = "UTC+03:00 (Arabia Standard Time)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "SEN", Name = "Senegal", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "SRB", Name = "Serbia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "SYC", Name = "Seychelles", TimeZone = "UTC+04:00 (Seychelles Time)", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "SLE", Name = "Sierra Leone", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "SGP", Name = "Singapore", TimeZone = "UTC+08:00 (SST)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "SVK", Name = "Slovakia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "SVN", Name = "Slovenia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "SLB", Name = "Solomon Islands", TimeZone = "UTC+11:00", UtcOffset = 11.0f });
            context.Countries.Add(new Country() { Code = "SOM", Name = "Somalia", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "ZAF", Name = "South Africa", TimeZone = "UTC+02:00 (South African Standard Time)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "SSD", Name = "South Sudan", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "ESP", Name = "Spain", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "LKA", Name = "Sri Lanka", TimeZone = "UTC+05:30 (SLST)", UtcOffset = 5.5f });
            context.Countries.Add(new Country() { Code = "SDN", Name = "Sudan", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "SUR", Name = "Suriname", TimeZone = "UTC−03:00", UtcOffset = -3.0f });
            context.Countries.Add(new Country() { Code = "SWZ", Name = "Swaziland", TimeZone = "UTC+02:00", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "SWE", Name = "Sweden", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "CHE", Name = "Switzerland", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "SYR", Name = "Syrian Arab Republic", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "TWN", Name = "Taiwan", TimeZone = "UTC+08:00 (Taiwan)", UtcOffset = 8.0f });
            context.Countries.Add(new Country() { Code = "TJK", Name = "Tajikistan", TimeZone = "UTC+05:00", UtcOffset = 5.0f });
            context.Countries.Add(new Country() { Code = "TZA", Name = "Tanzania, United Republic of", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "THA", Name = "Thailand", TimeZone = "UTC+07:00 (THA)", UtcOffset = 7.0f });
            context.Countries.Add(new Country() { Code = "TGO", Name = "Togo", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "TON", Name = "Tonga", TimeZone = "UTC+13:00", UtcOffset = 13.0f });
            context.Countries.Add(new Country() { Code = "TTO", Name = "Trinidad and Tobago", TimeZone = "UTC−04:00 (Trinidad and Tobago)", UtcOffset = -4.0f });
            context.Countries.Add(new Country() { Code = "TUN", Name = "Tunisia", TimeZone = "UTC+01:00 (CET)", UtcOffset = 1.0f });
            context.Countries.Add(new Country() { Code = "TUR", Name = "Turkey", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "TKM", Name = "Turkmenistan", TimeZone = "UTC+05:00 (Turkmenistan)", UtcOffset = 5.0f });
            context.Countries.Add(new Country() { Code = "TUV", Name = "Tuvalu", TimeZone = "UTC+12:00 (Tuvalu)", UtcOffset = 12.0f });
            context.Countries.Add(new Country() { Code = "UGA", Name = "Uganda", TimeZone = "UTC+03:00 (EAT)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "UKR", Name = "Ukraine", TimeZone = "UTC+02:00 (EET)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "ARE", Name = "United Arab Emirates", TimeZone = "UTC+04:00 (United Arab Emirates)", UtcOffset = 4.0f });
            context.Countries.Add(new Country() { Code = "GBR", Name = "United Kingdom", TimeZone = "UTC (GMT)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "USA", Name = "United States", TimeZone = "UTC−06:00 (CST)", UtcOffset = -6.0f });
            context.Countries.Add(new Country() { Code = "URY", Name = "Uruguay", TimeZone = "UTC−03:00 (Uruguay)", UtcOffset = -3.0f });
            context.Countries.Add(new Country() { Code = "UZB", Name = "Uzbekistan", TimeZone = "UTC+05:00 (Uzbekistan Time)", UtcOffset = 5.0f });
            context.Countries.Add(new Country() { Code = "VEN", Name = "Venezuela, Bolivarian Republic of", TimeZone = "UTC−04:30 (Venezuela)", UtcOffset = -4.5f });
            context.Countries.Add(new Country() { Code = "VNM", Name = "Viet Nam", TimeZone = "UTC+07:00 (Indochina Time)", UtcOffset = 0.0f });
            context.Countries.Add(new Country() { Code = "ESH", Name = "Western Sahara", TimeZone = "UTC+07:00 (Indochina Time)", UtcOffset = 7.0f });
            context.Countries.Add(new Country() { Code = "YEM", Name = "Yemen", TimeZone = "UTC+03:00 (Yemen)", UtcOffset = 3.0f });
            context.Countries.Add(new Country() { Code = "ZMB", Name = "Zambia", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });
            context.Countries.Add(new Country() { Code = "ZWE", Name = "Zimbabwe", TimeZone = "UTC+02:00 (CAT)", UtcOffset = 2.0f });

            context.SaveChanges();
        }
    }
}