# 🏥 Patient Management System (Console-Based | C#)

## 📌 Project Overview

The **Patient Management System** is a **console-based C# application** designed to manage different types of patients in a hospital environment. The system strictly follows **Object-Oriented Programming (OOP)** principles and uses **Delegates and Events** to implement **dynamic billing strategies** and **real-time hospital notifications**.

This project is suitable for:

* Academic assessments (HCL-style assessments)
* OOP and C# practice
* Viva and interview demonstrations

---

## 🎯 Problem Statement

A hospital wants to develop a console-based Patient Management System that:

* Manages different patient types
* Calculates treatment bills dynamically
* Applies billing strategies using delegates
* Sends real-time notifications using events
* Follows object-oriented and event-driven design principles

---

## 🔁 System Flow

1. Admit patient
2. Select patient type
3. Calculate base treatment bill
4. Apply billing strategy (Delegate)
5. Generate final bill
6. Trigger events and notify departments

---

## 🧠 Concepts Used

### ✅ Object-Oriented Programming (OOP)

* **Encapsulation** – Properties with getters/setters
* **Inheritance** – Common `Patient` base class
* **Polymorphism** – Overridden billing logic
* **Abstraction** – Abstract methods in base class

### ✅ Delegates

* Used for **dynamic billing strategies**
* Allows switching billing logic at runtime

### ✅ Events

* Used for **hospital notifications**
* Implements **Publisher–Subscriber pattern**

---

## 🧩 Class Design

### 1️⃣ Patient (Abstract Base Class)

* Stores common patient data
* Declares abstract billing method

### 2️⃣ InPatient (Derived Class)

* Billing based on number of days admitted

### 3️⃣ OutPatient (Derived Class)

* Billing based on consultation fee

### 4️⃣ Emergency (Derived Class)

* Billing includes emergency charges

### 5️⃣ BillingDelegate

* Delegate used to apply billing strategy

### 6️⃣ BillingStrategies

* Normal Billing
* Insurance Billing (Discount applied)

### 7️⃣ Hospital (Event Publisher)

* Triggers notifications

### 8️⃣ Departments (Subscribers)

* Pharmacy
* Billing Department

---

## 🧪 Billing Strategies (Delegate)

```csharp
public delegate double BillingDelegate(double amount);
```

### Available Strategies:

* **Normal Billing** – No discount
* **Insurance Billing** – 30% discount

---

## 🔔 Event-Driven Notifications

### Event Declaration

```csharp
public event HospitalEventHandler NotifyDepartments;
```

### Triggered When:

* Patient is admitted
* Bill is generated

### Subscribers:

* Pharmacy Department
* Billing Department

---

## 📊 Evaluation Criteria Mapping

| Criteria        | Implementation                            |
| --------------- | ----------------------------------------- |
| Class & Objects | Patient, InPatient, OutPatient, Emergency |
| OOP Concepts    | Inheritance, Polymorphism, Abstraction    |
| Delegates       | BillingDelegate                           |
| Events          | Hospital notifications                    |
| Total           | 25 / 25                                   |

---

## 🧠 Sample Output

```text
--- BILL GENERATED ---
Patient Name: Rahul
Patient Type: Emergency
Total Amount: 8400

Pharmacy Notification: Patient Rahul billing completed.
Billing Notification: Patient Rahul billing completed.
```

---

## ▶️ How to Run the Project

1. Open **Visual Studio**
2. Create a **Console Application (.NET)**
3. Add the project files
4. Run using **Ctrl + F5**

---

## 🚀 Future Enhancements

* Add database support (SQL Server / MySQL)
* Add file logging
* Add role-based access
* Convert to ASP.NET Core Web API
* Add unit testing

---

## 🎤 Viva / Interview One-Liner

> “This console-based Patient Management System demonstrates strong OOP principles, dynamic billing using delegates, and real-time hospital notifications using event-driven programming in C#.”

---

## 👨‍💻 Author

**Hritik Sagar Srivastava**
Backend Developer | C# | Java | Spring Boot | DevOps

---

## 📜 License

This project is created for educational and assessment purposes.
