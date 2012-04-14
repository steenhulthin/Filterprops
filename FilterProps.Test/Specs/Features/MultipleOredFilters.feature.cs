﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17379
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FilterProps.Test.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddingMultipleFiltersWhichAreORedTogetherFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MultipleOredFilters.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Adding multiple filters which are ORed together", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Adding multiple filters which are ORed together")))
            {
                FilterProps.Test.Specs.Features.AddingMultipleFiltersWhichAreORedTogetherFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Gender",
                        "IsInternational"});
            table1.AddRow(new string[] {
                        "Jesse",
                        "Fredericks",
                        "Male",
                        "false"});
            table1.AddRow(new string[] {
                        "Elenor",
                        "Ruel",
                        "Female",
                        "true"});
            table1.AddRow(new string[] {
                        "Hàn Ngọc",
                        "Trai",
                        "Female",
                        "true"});
            table1.AddRow(new string[] {
                        "Catherine",
                        "Jackson",
                        "Female",
                        "false"});
            table1.AddRow(new string[] {
                        "Mahjub Khalid",
                        "Khalid",
                        "Male",
                        "true"});
            table1.AddRow(new string[] {
                        "Ashwàq Jawahir",
                        "Shalhoub",
                        "Male",
                        "false"});
            table1.AddRow(new string[] {
                        "Douglas",
                        "Rego",
                        "Male",
                        "false"});
            table1.AddRow(new string[] {
                        "Jose",
                        "Kitterman",
                        "Female",
                        "false"});
            table1.AddRow(new string[] {
                        "Nancy",
                        "Jackson",
                        "Female",
                        "false"});
            table1.AddRow(new string[] {
                        "Jose",
                        "Roberts",
                        "Male",
                        "false"});
            table1.AddRow(new string[] {
                        "Bob",
                        "Jackson",
                        "Male",
                        "false"});
            table1.AddRow(new string[] {
                        "Bobby",
                        "Rackson",
                        "Female",
                        "false"});
            table1.AddRow(new string[] {
                        "Boba",
                        "Bob Jackson",
                        "Female",
                        "true"});
#line 6
 testRunner.Given("These students:", ((string)(null)), table1);
#line 21
 testRunner.And("I add a filter where LastName contains Jackson");
#line 22
 testRunner.And("I OR a filter where Gender is Female");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple filters with Lastname OR Gender")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Adding multiple filters which are ORed together")]
        public virtual void MultipleFiltersWithLastnameORGender()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple filters with Lastname OR Gender", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 26
 testRunner.When("I apply the filters");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Gender",
                        "IsInternational"});
            table2.AddRow(new string[] {
                        "Elenor",
                        "Ruel",
                        "Female",
                        "true"});
            table2.AddRow(new string[] {
                        "Hàn Ngọc",
                        "Trai",
                        "Female",
                        "true"});
            table2.AddRow(new string[] {
                        "Catherine",
                        "Jackson",
                        "Female",
                        "false"});
            table2.AddRow(new string[] {
                        "Jose",
                        "Kitterman",
                        "Female",
                        "false"});
            table2.AddRow(new string[] {
                        "Nancy",
                        "Jackson",
                        "Female",
                        "false"});
            table2.AddRow(new string[] {
                        "Bob",
                        "Jackson",
                        "Male",
                        "false"});
            table2.AddRow(new string[] {
                        "Bobby",
                        "Rackson",
                        "Female",
                        "false"});
            table2.AddRow(new string[] {
                        "Boba",
                        "Bob Jackson",
                        "Female",
                        "true"});
#line 27
 testRunner.Then("These students should be on the list", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple filters with Lastname OR Gender OR FirstName is Ashwàq")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Adding multiple filters which are ORed together")]
        public virtual void MultipleFiltersWithLastnameORGenderORFirstNameIsAshwaq()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple filters with Lastname OR Gender OR FirstName is Ashwàq", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 41
 testRunner.And("I OR a filter where FirstName is Ashwàq");
#line 42
 testRunner.When("I apply the filters");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Gender",
                        "IsInternational"});
            table3.AddRow(new string[] {
                        "Elenor",
                        "Ruel",
                        "Female",
                        "true"});
            table3.AddRow(new string[] {
                        "Hàn Ngọc",
                        "Trai",
                        "Female",
                        "true"});
            table3.AddRow(new string[] {
                        "Catherine",
                        "Jackson",
                        "Female",
                        "false"});
            table3.AddRow(new string[] {
                        "Ashwàq Jawahir",
                        "Shalhoub",
                        "Male",
                        "false"});
            table3.AddRow(new string[] {
                        "Jose",
                        "Kitterman",
                        "Female",
                        "false"});
            table3.AddRow(new string[] {
                        "Nancy",
                        "Jackson",
                        "Female",
                        "false"});
            table3.AddRow(new string[] {
                        "Bob",
                        "Jackson",
                        "Male",
                        "false"});
            table3.AddRow(new string[] {
                        "Bobby",
                        "Rackson",
                        "Female",
                        "false"});
            table3.AddRow(new string[] {
                        "Boba",
                        "Bob Jackson",
                        "Female",
                        "true"});
#line 43
 testRunner.Then("These students should be on the list", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion