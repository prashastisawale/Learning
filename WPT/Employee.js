export class Employee {

    constructor(firstName, lastName, email, designation, basicSalary) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.designation = designation;
        this.basicSalary = basicSalary;
    }

  
    setFirstName(firstName) {
        this.firstName = firstName;
    }

    setLastName(lastName) {
        this.lastName = lastName;
    }

    setEmail(email) {
        this.email = email;
    }

    setDesignation(designation) {
        this.designation = designation;
    }

    setBasicSalary(basicSalary) {
        this.basicSalary = basicSalary;
    }

 
    getFirstName() {
        return this.firstName;
    }

    getLastName() {
        return this.lastName;
    }

    getEmail() {
        return this.email;
    }

    getDesignation() {
        return this.designation;
    }

    getBasicSalary() {
        return this.basicSalary;
    }

  
    display() {
        console.log("First Name:", this.firstName);
        console.log("Last Name:", this.lastName);
        console.log("Email:", this.email);
        console.log("Designation:", this.designation);
        console.log("Basic Salary:", this.basicSalary);
    }
}

export default Employee;

