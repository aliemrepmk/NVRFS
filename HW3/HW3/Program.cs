using HW3;

// Q1
Console.WriteLine("Q1");

Manager managerAccount = new Manager();
managerAccount.employeeId = 1;
managerAccount.employeeName = "Ahmet";
managerAccount.employeeSalary = 60000;
managerAccount.employeeDepartment = "Software Development";
managerAccount.teamSize = 12;

Developer developerAccount = new Developer();
developerAccount.employeeId = 2;
developerAccount.employeeName = "Ali";
developerAccount.employeeSalary = 50000;
developerAccount.employeeDepartment = "Software Development";
developerAccount.about = "3+ years experience";

Console.WriteLine("Manager Info");
Console.WriteLine("ID: " + managerAccount.employeeId);
Console.WriteLine("Name: " + managerAccount.employeeName);
Console.WriteLine("Department: " + managerAccount.employeeDepartment);
Console.WriteLine("Team size: " + managerAccount.teamSize);
Console.WriteLine("Salary: " + managerAccount.employeeSalary);
Console.WriteLine("Bonus: " + managerAccount.CalculateBonus(managerAccount.employeeSalary));

Console.WriteLine("\nDeveloper Info");
Console.WriteLine("ID: " + developerAccount.employeeId);
Console.WriteLine("Name: " + developerAccount.employeeName);
Console.WriteLine("Department: " + developerAccount.employeeDepartment);
Console.WriteLine("About: " + developerAccount.about);
Console.WriteLine("Salary: " + developerAccount.employeeSalary);
Console.WriteLine("Bonus: " + developerAccount.CalculateBonus(developerAccount.employeeSalary));

// Q2
Console.WriteLine("\n\nQ2");

SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.accountHolder = "Zeynep";
savingsAccount.accountBalance = 7246.21;

CheckingAccount checkingAccount = new CheckingAccount();
checkingAccount.accountHolder = "Ayşe";
checkingAccount.accountBalance = 17002.56;

Console.WriteLine("Savings account info");
Console.WriteLine("Account holder: " + savingsAccount.accountHolder);
Console.WriteLine("Account balance: " + savingsAccount.accountBalance);
savingsAccount.CalculateInterest();

Console.WriteLine("\nChecking account info");
Console.WriteLine("Account holder: " + checkingAccount.accountHolder);
Console.WriteLine("Account balance: " + checkingAccount.accountBalance);
checkingAccount.CalculateInterest();