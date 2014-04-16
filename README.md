learn-specflow
==============

A simple .NET web application and tests to help teaching Specflow (Gherkin), NUnit, Coypu

** You will need Visual Studio Professional (2012 or later) for this tutorial. There is a work-around using the Express Versions (see https://github.com/techtalk/SpecFlow/wiki/Visual-Studio-Express-Integration) but, due to time constraints in this live coding presentation, we won´t be following that path.

** You can setup the VS to run NUnit tests. I prefer to use the external GUI, though...

Before we begin
=====
  * Install Visual Studio 2012 or later
  * Go to Tools -> Online and type "Specflow" in the search box. Select the package and click on "Download". This will install the Specflow extension to your VS
  * Download the NUnit stable release from http://www.nunit.org/
  * Get your System Under Test (SUT) up and running
 
Setup
=====
  1. Create a new Class Library project for the tests. (use .NET Framework 4.0 or later) 
  2. Using the package manager, install the following packages:
    * SpecFlow.NUnit
    * Coypu
  3. Open the App.config and, inside the Specflow tag, add 
```
<language feature="pt-br" />
```
You will have something like:
```
  <specFlow>
    <language feature="pt-br" />
    <!-- For additional details on SpecFlow configuration options see http://go.specflow.org/doc-config -->
    <!-- For additional details on SpecFlow configuration options see http://go.specflow.org/doc-config -->
    <unitTestProvider name="NUnit"/>
  </specFlow>
```

