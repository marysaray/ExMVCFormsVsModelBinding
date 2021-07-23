# Example MVC Forms vs Model Binding
HTML Forms vs ASP.NET Core Model Binding

*Demo: Getting Student Data*
    
    1.) Create a controller, action and view
    
    2.) Add the HTML Form to the view
        * Give all form inputs name attributes
        * Where does the form go on submit?
        
    3.) Create HttpPost version of action
        * Handles data submission
        * Validate the data
        * Map to C# object
        
*Demo: Student data with Model Binding*

    1.) Create a new action and view with model binding
    
    2.) Add data annotation to class to generate validation code
        * Annotations are attributes on properties
        * Required, data type, length, regular expression, email and more
        * System.ComponentModel.DataAnnotations;
        
    3.) Create an HttpPost action that is model bound
        * Validate data
        * Add to database

Partial View Resource: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/partial?view=aspnetcore-3.1
