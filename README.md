What is Filterprops?
--------------------

Filterprops is a portable, multi-platform, and the reloaded version of FilterFramework. Basically, it allows you to filter a list of objects based on some object's properties. FilterFramework requires you to pass strings, in form of expressions, to build filters. Filterprops, on the other hand, allows you to create strongly typed filter expressions using fluent interface. Filterprops is written using the Portable Library Tools and thus a single dll can run on multiple platforms without recompiling.

Supported Platforms:
--------------------

*	.NET Framework 4 and higher
*	Silverlight 4 and higher
*	Windows Phone 7.5
*	.NET for Metro Style apps


Usage:
------

Say you have a list of students:

    // students
    var students = new List<Student>
                                   {
                                       new Student(),
                                       new Student(),
                                       new Student(),
                                       new Student(),
                                       new Student(),
                                   };
    
    
    // create a filter service:
    var filterService = new FilterService<Student>();
    
    // start adding a filter; by default an ANDed filter is created:
    var andFilter =  filterService.AddBinaryFilter(e=>e.FirstName == "John");
    
    // or, to make it more readable, you can also do:
    var andFilter = filterService.DoAndWith(e=>e.FirstName == "John");
    
    // if you need an ORed filter instead:
    var orFilter = filterSevice.DoOrWith(e=>e.LastName == "Jackson");
    
    // now you can apply the filters to students list:
    var filteredStudentsList = filterService.Filter(students);


Grouping:
---------

You can also group a filter collection and either AND or OR with another collection.
Say, we want to create a new filter group and like to AND with the filters we created above.
You will do this like so:

    // create a new collection:
    var newFiltersCollection = new FilterCollection<T>();
    
    // create bunch of filters:
    var genderFilter = new BinaryFilterExpression<T>(e=>e.Gender == GenderEnum.Female); // ANDed by default
    var ageFilter = new BinaryFilterExpression<T>(e=>e.Age > 27) { ItsDoAndFlag = false }; // ORed by setting ItsDoAndFlag to false
    
    // add the filters to new collection:
    newFiltersCollection.Add(genderFilter);
    newFiltersCollection.Add(ageFilter);
    
    // now AND with filterService's collection:
    filterService.DoAndWith(newFiltersCollection);
    
    // create a new collection:
    var groupedFilteredStudentsList = filterService.Filter(students);
