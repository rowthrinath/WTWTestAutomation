using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

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
                Assert.Equal(EurItem.ItemArray[0], Convert.ToInt32(SterlingValue.SCurrency1 * ConversionRate));
                Assert.Equal(EurItem.ItemArray[1], Convert.ToInt32(SterlingValue.SCurrency2 * ConversionRate));
                Assert.Equal(EurItem.ItemArray[2], Convert.ToInt32(SterlingValue.SCurrency3 * ConversionRate));
                Assert.Equal(EurItem.ItemArray[3], Convert.ToInt32(SterlingValue.SCurrency4 * ConversionRate));
                break;
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

