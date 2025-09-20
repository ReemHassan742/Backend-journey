var employeeId = 10;  
var employeeName = "Ahmed";
var departmentId = 9999;
var departmentName = "Engineering";
function getEmployeeId() {
    return employeeId;
}
function setEmployeeId(value) {
    employeeId = value;
}
function getEmployeeName() {
    return employeeName;
}
function setEmployeeName(value) {
    employeeName = value;
}

function getDepartmentId() {
    return departmentId;
}
function setDepartmentId(value) {
    departmentId = value;
    employeeId = 10; //The setDepartmentId fucntion add value to EmployeeId 
}
function getDepartmentName() {
    return departmentName;
}
function setDepartmentName(value) {
    departmentName = value;
}
/***********************************************/

class Department {
    id;    
    name;  
    getId() {
        return this.id;
    }
    setId(value) {
        this.id = value;
    }
    getName() {
        return this.name;
    }
    setName(value) {
        this.name = value;
    }
}
const department = new Department();
department.setId(9999);
department.setName("Engineering");
console.log(department.getId());   // Output: 9999
console.log(department.getName()); // Output: Engineering



class Employee {
    id;    
    name;  
    getId() {
        return this.id;
    }
    setId(value) {
        this.id = value;
    }
    getName() {
        return this.name;
    }
    setName(value) {
        this.name = value;
    }
}
const employee = new Employee();
employee.setId(10);
employee.setName("Mariam");
console.log(employee.getId());   // Output: 10
console.log(employee.getName()); // Output: Mariam


