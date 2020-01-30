// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WTWTestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CompareRateTablesFeature : object, Xunit.IClassFixture<CompareRateTablesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CompareRateTables.feature"
#line hidden
        
        public CompareRateTablesFeature(CompareRateTablesFeature.FixtureData fixtureData, WTWTestAutomation_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CompareRateTables", "\tIn order to compare two rate tables\r\n\tAs a tester\r\n\tI want the below tests to co" +
                    "mpare the conversion rates", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="To test the conversion rate for sterling to euro")]
        [Xunit.TraitAttribute("FeatureTitle", "CompareRateTables")]
        [Xunit.TraitAttribute("Description", "To test the conversion rate for sterling to euro")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.InlineDataAttribute("Product1", "1.5", "10", "12", "14", "45", "80", "15", "18", "21", "67.5", "120", new string[0])]
        [Xunit.InlineDataAttribute("Product2", "1.5", "20", "15", "24", "0", "87", "30", "22.5", "36", "0", "130.5", new string[0])]
        [Xunit.InlineDataAttribute("Product3", "1.5", "22", "60", "0", "0", "38", "33", "90", "0", "0", "57", new string[0])]
        [Xunit.InlineDataAttribute("Product4", "1.5", "28", "0", "0", "0", "45", "42", "0", "0", "0", "67.5", new string[0])]
        public virtual void ToTestTheConversionRateForSterlingToEuro(string product, string conversionRate, string sCurrency1, string sCurrency2, string sCurrency3, string sCurrency4, string sTotal, string eCurrency1, string eCurrency2, string eCurrency3, string eCurrency4, string eTotal, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To test the conversion rate for sterling to euro", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table1.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 9
 testRunner.Given("I have two data tables created for sterling and euro currencies", ((string)(null)), table1, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "ConversionRate"});
                table2.AddRow(new string[] {
                            string.Format("{0}", conversionRate)});
#line 12
 testRunner.And("I have set a conversion rate as", ((string)(null)), table2, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table3.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 15
 testRunner.Then("I should see the below conversion rates for sterling to euro", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="To test the conversion rate for sterling to euro\twith incorrect conversion rate")]
        [Xunit.TraitAttribute("FeatureTitle", "CompareRateTables")]
        [Xunit.TraitAttribute("Description", "To test the conversion rate for sterling to euro\twith incorrect conversion rate")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.InlineDataAttribute("Product1", "20.0", "10", "12", "14", "45", "80", "15", "18", "21", "67.5", "120", new string[0])]
        public virtual void ToTestTheConversionRateForSterlingToEuroWithIncorrectConversionRate(string product, string conversionRate, string sCurrency1, string sCurrency2, string sCurrency3, string sCurrency4, string sTotal, string eCurrency1, string eCurrency2, string eCurrency3, string eCurrency4, string eTotal, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To test the conversion rate for sterling to euro\twith incorrect conversion rate", null, @__tags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table4.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 28
 testRunner.Given("I have two data tables created for sterling and euro currencies", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "ConversionRate"});
                table5.AddRow(new string[] {
                            string.Format("{0}", conversionRate)});
#line 31
 testRunner.And("I have set a conversion rate as", ((string)(null)), table5, "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table6.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 34
 testRunner.Then("I should see the below conversion rates for sterling to euro", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="To test the conversion rate for sterling to euro\twith zero conversion rate")]
        [Xunit.TraitAttribute("FeatureTitle", "CompareRateTables")]
        [Xunit.TraitAttribute("Description", "To test the conversion rate for sterling to euro\twith zero conversion rate")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.InlineDataAttribute("Product1", "0", "10", "12", "14", "45", "80", "15", "18", "21", "67.5", "120", new string[0])]
        public virtual void ToTestTheConversionRateForSterlingToEuroWithZeroConversionRate(string product, string conversionRate, string sCurrency1, string sCurrency2, string sCurrency3, string sCurrency4, string sTotal, string eCurrency1, string eCurrency2, string eCurrency3, string eCurrency4, string eTotal, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To test the conversion rate for sterling to euro\twith zero conversion rate", null, @__tags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table7.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 44
 testRunner.Given("I have two data tables created for sterling and euro currencies", ((string)(null)), table7, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "ConversionRate"});
                table8.AddRow(new string[] {
                            string.Format("{0}", conversionRate)});
#line 47
 testRunner.And("I have set a conversion rate as", ((string)(null)), table8, "And ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Product",
                            "SCurrency1",
                            "SCurrency2",
                            "SCurrency3",
                            "SCurrency4",
                            "STotal",
                            "ECurrency1",
                            "ECurrency2",
                            "ECurrency3",
                            "ECurrency4",
                            "ETotal"});
                table9.AddRow(new string[] {
                            string.Format("{0}", product),
                            string.Format("{0}", sCurrency1),
                            string.Format("{0}", sCurrency2),
                            string.Format("{0}", sCurrency3),
                            string.Format("{0}", sCurrency4),
                            string.Format("{0}", sTotal),
                            string.Format("{0}", eCurrency1),
                            string.Format("{0}", eCurrency2),
                            string.Format("{0}", eCurrency3),
                            string.Format("{0}", eCurrency4),
                            string.Format("{0}", eTotal)});
#line 50
 testRunner.Then("I should see the below conversion rates for sterling to euro", ((string)(null)), table9, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CompareRateTablesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CompareRateTablesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion