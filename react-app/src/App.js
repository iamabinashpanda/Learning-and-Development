import React, { useState } from "react";
import "./App.css";
import Card from "./components/UI/Card";
import NewExpense from "./components/NewExpense/NewExpense";
import ExpenseFilter from "./components/NewExpense/ExpenseFilter";
import ExpenseList from "./components/Expenses/ExpenseList";
import ExpenseChart from "./components/Expenses/ExpenseChart";
const App = () => {
  const DUMMY_EXPENSES = [
    {
      id: "e123",
      title: "Car Insurance",
      amount: 64.22,
      date: new Date(2021, 2, 25),
    },
    {
      id: "e2",
      title: "Bike Insurance",
      amount: 645.22,
      date: new Date(2021, 2, 25),
    },
    {
      id: "e3",
      title: "Home Insurance",
      amount: 94.82,
      date: new Date(2021, 2, 25),
    },
    {
      id: "e4",
      title: "Health Insurance",
      amount: 645.22,
      date: new Date(2021, 2, 25),
    },
  ];
  const [expenses, setExpenses] = useState(DUMMY_EXPENSES);

  const addEexpenseHandler = (expense) => {
    setExpenses((prevExpense) => {
      return [expense, ...prevExpense];
    });
  };
  const [filteredYear, setFilteredYear] = useState("2020");
  const filterChangeHandler = (selectedYear) => {
    setFilteredYear(selectedYear);
  };
  const filterExpenses = expenses.filter((expenses) => {
    return expenses.date.getFullYear().toString() === filteredYear;
  });
  return (
    <div>
      <NewExpense onAddExpense={addEexpenseHandler} />
      <li>
        <Card className="expenses">
          <ExpenseFilter
            selected={filteredYear}
            onChangeFilter={filterChangeHandler}
          />
          <ExpenseChart expenses={filterExpenses}/>
          <ExpenseList expenses={filterExpenses} />
          {/* {filterExpenses.map(expenses => <ExpenseItem key = {expenses.id} expense = {expenses} ></ExpenseItem>)} */}
          {/* <ExpenseItem expense={expenses[0]} />
        <ExpenseItem expense={expenses[1]} />
        <ExpenseItem expense={expenses[2]} />
        <ExpenseItem expense={expenses[3]} /> */}
        </Card>
      </li>
    </div>
  );
};

export default App;
