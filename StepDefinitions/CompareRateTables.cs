using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace WTWTestAutomation.StepDefinitions
{
    [Binding]
    public sealed class CompareRateTables
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;
        public DataTable SCurrencyTable;
        private DataTable ECurrencyTable;
        public double ConversionRate;


        public CompareRateTables(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I have two data tables created for sterling and euro currencies")]
        public void GivenIHaveTwoDataTablesCreatedForSterlingAndEuroCurrencies(Table table)
        {
            var SterlingData = table.CreateInstance<SterlingModal>();
            var EuroData = table.CreateInstance<EuroModal>();
            SCurrencyTable = TestActions.GetSterlingCurrencyData(SterlingData.SCurrency1, SterlingData.SCurrency2,
                                SterlingData.SCurrency3, SterlingData.SCurrency4, SterlingData.STotal);
            ECurrencyTable = TestActions.GetEuroCurrencyData(EuroData.ECurrency1, EuroData.ECurrency2, EuroData.ECurrency3, EuroData.ECurrency4,
                                        EuroData.ETotal);
        }        

        [Then(@"I should see the below conversion rates for sterling to euro")]
        public void ThenIShouldSeeTheBelowConversionRatesForSterlingToEuro(Table table)
        {
            var SterlingValue = table.CreateInstance<SterlingModal>();            

            foreach (DataRow EurItem in ECurrencyTable.Rows)
            {
                EurItem.ItemArray[0].Equals(SterlingValue.SCurrency1 * ConversionRate) ;
                EurItem.ItemArray[1].Equals(SterlingValue.SCurrency2 * ConversionRate);
                EurItem.ItemArray[2].Equals(SterlingValue.SCurrency3 * ConversionRate);
                EurItem.ItemArray[3].Equals(SterlingValue.SCurrency4 * ConversionRate);
            }

        }

        [Given(@"I have set a conversion rate as")]
        public void GivenIHaveSetAConversionRateAs(Table table)
        {
            var convRate = table.CreateInstance<RateModal>();
            ConversionRate = convRate.ConversionRate;
        }

    }
}

