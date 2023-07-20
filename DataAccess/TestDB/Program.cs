﻿using Testing;
using HR;

List<Department> departments = DBTestManager.GetAllDepartments();
foreach(Department dept in departments){
    Console.WriteLine(dept.Name+" "+dept.Location);
}

//Database Operations unit testing