# 🏦 C# Banking System Console App

A simple yet powerful **Banking System** built using **C#** and **Object-Oriented Programming (OOP)** concepts.
This project simulates a real-world bank account with transactions, validation, and a clean console UI.

---

## 🚀 Features

* ✅ Create a bank account with initial balance
* 💰 Deposit money
* 💸 Withdraw money with validation (no overdraft)
* 📊 Check current balance
* 🧾 View transaction history (Statement)
* 🏦 Change bank name (Static feature)
* 🔒 Encapsulation & data protection using OOP principles

---

## 🧠 Concepts Used

* Object-Oriented Programming (OOP)

  * Classes & Objects
  * Encapsulation
  * Static Members
* Collections (`List`, `ReadOnlyCollection`)
* Input Validation (`TryParse`)
* Console-based UI

---

## 🖥️ Sample Run

```text
╔════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                ║
║                                       Welcome to Our Bank                                      ║
║                                                                                                ║
╚════════════════════════════════════════════════════════════════════════════════════════════════╝

Enter your name: Sultan Farag Amin

MENU:
1. Deposit
2. Withdraw
3. Check Balance
4. Statement
5. Change Bank Name
6. Exit

> Deposit: 100000
✔ Deposited 100,000.00

> Withdraw: 1000
✔ Withdrew 1,000.00

> Balance:
💰 99,000.00

> Statement:
Bank   : Assiut National Bank
Holder : Sultan Farag Amin
Balance: 99,000.00

Transactions:
- Deposit    $100,000.00
- Withdrawal $1,000.00

> Change Bank Name:
GitHub Bank

> Exit
```

---

## 🏗️ Project Structure

```
BankingSystem/
│
├── Program.cs        # Main menu and user interaction
├── BankAccount.cs    # Core banking logic
└── Transaction.cs    # Transaction model
```

---

## ⚙️ How to Run

```bash
dotnet new console -n BankingSystem
cd BankingSystem
dotnet run
```

---

## 📌 Key Highlights

* 💡 Uses **decimal** for accurate financial calculations
* 🛡️ Prevents invalid inputs and overdrawing
* 🔍 Clean separation between logic and UI
* 📈 Easily extendable (multi-user, database, GUI)

---

## 🔥 Future Improvements

* 💾 Save data using JSON / Database
* 👤 Multi-user system (Login/Register)
* 🌐 Convert to Web API (ASP.NET)
* 🖥️ GUI using Windows Forms or WPF

---

## 👨‍💻 Author

**Sultan Farag Amin**
Software Engineering Student

---

## ⭐ Don't forget

If you like this project:

* ⭐ Star the repo
* 🍴 Fork it
* 🛠️ Improve it

---

> Built with ❤️ using C#
