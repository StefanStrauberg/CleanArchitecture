# 🏗️ S.O.L.I.D. Principles

**S.O.L.I.D** improves the maintainability, scalability, and readability of software systems.

## 📜 The Five Principles

### 1️⃣ Single Responsibility Principle (SRP)

**"A class should have only one reason to change."**

- Each class should do **one thing** well.
- Keeps code **modular** and **maintainable**.

### 2️⃣ Open/Closed Principle (OCP)

**"Software entities should be open for extension, but closed for modification."**

- Add functionality **without altering** existing code.
- Use **abstraction and inheritance**.

### 3️⃣ Liskov Substitution Principle (LSP)

**"Derived classes should be substitutable for their base classes."**

- Subclasses should replace superclasses **without breaking the application**.
- Ensures **robust inheritance**.

### 4️⃣ Interface Segregation Principle (ISP)

**"No client should be forced to depend on methods it does not use."**

- Create **small, specific** interfaces.
- Improves **flexibility** and **organization**.

### 5️⃣ Dependency Inversion Principle (DIP)

**"Depend on abstractions, not on concrete implementations."**

- High-level modules should not depend on low-level modules.
- Use **interfaces or abstract classes**.

## 🚀 Benefits of S.O.L.I.D.

✔️ Improves **code maintainability**<br>
✔️ Enhances **scalability**<br>
✔️ Makes debugging and testing **easier**<br>
✔️ Promotes **better software architecture**<br>

---

# 💧 DRY Principles

**DRY (Don't Repeat Yourself)** emphasizes reducing redundancy to improve maintainability, scalability, and readability.

## 📝 Core Concepts

### 1️⃣ Reusability

**"Code should be reusable across different parts of the application."**

- Write **modular** code.
- Promotes **consistent** and **efficient** practices.

### 2️⃣ Maintainability

**"Reduce the amount of code to make it easier to manage."**

- Avoids duplication, making **updates** easier.
- Simplifies **maintenance**.

### 3️⃣ Readability

**"Improve code readability by avoiding redundancy."**

- Clear code enhances **comprehension**.
- Facilitates **collaboration**.

## 📚 Key Practices

- **🔍 Abstraction**: Encapsulate common code into **functions** or **classes**.
- **🧩 Modularity**: Divide code into **reusable modules**.
- **🛠️ Code Generation**: Use templates or tools to automate repetitive tasks.

## 🚀 Benefits of D.R.Y.

✔️ **Efficiency**: Saves time and effort.<br>
✔️ **Consistency**: Ensures uniformity.<br>
✔️ **Scalability**: Simplifies extending applications.<br>

---

# 🧼 Clean Architecture

"Clean Architecture" is a design philosophy that promotes a robust, maintainable, and scalable software architecture, primarily advocated by Robert C. Martin.

## 📚 Core Concepts

### 1️⃣ Independence of Frameworks

**"The architecture does not depend on the existence of some library of feature-laden software."**

- Frameworks are **tools** and should be easily replaceable.
- Keeps the core business logic **independent**.

### 2️⃣ Testability

**"The business rules can be tested without the UI, database, web server, or any other external element."**

- Promotes **independent** and **automated** testing.
- Ensures the code is **reliable** and **bug-free**.

### 3️⃣ UI Independence

**"The UI can change easily, without changing the rest of the system."**

- User interface changes should not affect the core **business logic**.
- Enables **flexibility** in adapting to new UI requirements.

### 4️⃣ Database Independence

**"The business rules are not bound to the database."**

- Databases should be treated as **details**, not central elements.
- Allows for **easy migration** between different database systems.

### 5️⃣ External Agency Independence

**"The business rules do not know anything at all about the outside world."**

- Isolate business logic from external systems and **services**.
- Ensures **decoupling** and **modularity**.

## 📜 Architecture Layers

### 💼 Entities

- **Enterprise-wide** business rules.
- Highly reusable across different applications.

### 🌐 Use Cases

- **Application-specific** business rules.
- Defines how the application **interacts** with the user.

### 🛠️ Interface Adapters

- Converts data between the **use cases** and **external** systems.
- Ensures **communication** between internal and external components.

### 🧩 Frameworks & Drivers

- **External tools** and libraries.
- Should be easily replaceable without affecting core logic.

## 🚀 Benefits of Clean Architecture

✔️ **Scalability**: Easy to extend and adapt.<br>
✔️ **Maintainability**: Simplifies updates and modifications.<br>
✔️ **Testability**: Facilitates thorough and independent testing.<br>
✔️ **Flexibility**: Allows easy changes to UI, database, and frameworks.<br>
