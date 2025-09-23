# 📚 GoodReads: A Personal Book Tracking System

## 📖 Description
**GoodReads** is a desktop-based **Personal Book Tracking System** built with **VB.NET** (front-end) and **Microsoft Access** (database).  
The system allows users to efficiently manage their personal book collection by storing and maintaining records such as book details, progress status, and providing functionalities to:

- Add new books
- Edit and update existing records
- Delete books
- Search books by various criteria
- Track reading progress (Add to Readlist, Reading, Read)

---

## 🎯 Scopes & Features

### **Form 1 (Main Window)**
- Displays all stored book records:  
  *Name of Book, Author, ISBN, Year Published, and Book Progress*
- Buttons:
  - **Add** → Opens Form 2  
  - **Edit** → Opens Form 3 for the selected record  
  - **Delete** → Removes selected record from the database  
  - **Search bar** → Opens Form 4  
- Initial view shows either an empty list (if no books) or a populated list of books.

---

### **Form 2 (Add Book Window)**
- Triggered by pressing **Add** on Form 1.
- Input fields:
  - Name of the Book
  - Author
  - ISBN
  - Year Published
  - Book Progress
- Buttons:
  - **Confirm** → Saves new book to database and updates Form 1
  - **Clear** → Clears all input fields
  - **Exit/Cancel** → Closes without saving

---

### **Form 3 (Edit Book Window)**
- Triggered by pressing **Edit** on Form 1 (after selecting a record).
- Pre-fills existing book information into editable fields.
- Buttons:
  - **Confirm** → Updates the database and refreshes Form 1
  - **Cancel** → Returns to Form 1 without saving changes

---

### **Form 4 (Search Book Window)**
- Triggered by typing in the **Search bar** or pressing a **Search button**.
- Allows searching books by:
  - ISBN
  - Name of Book
  - Author
  - Year Published
- Displays results in a list view.

---

## ⚠️ Limitations
- Manages only **book details and progress** (no borrower/member management).  
- **MS Access limitations** may restrict simultaneous multi-user access.  
- **Desktop-only**: no web or mobile version.  

---

## 👨‍💻 Developers
- **James Alba**  
- **Crystal Florano**  
- **Justine Pelgone**  
- **Jamin Villareal**  

---

## 🛠️ Tech Stack
- **Front-end:** VB.NET  
- **Database:** Microsoft Access  
- **Platform:** Windows (desktop application)  

---

