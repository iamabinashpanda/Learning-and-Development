import "./App.css";
import Card from "./components/UI/Card";
import ExpenseItem from "./components/Expenses/ExpenseItem";
import NewExpense from "./components/NewExpense/NewExpense";
const App = () => {
  const expenses = [
    { id:'e1',title: "Car Insurance", amount: 64.22, date: new Date(2021, 2, 25) },
    { id:'e2',title: "Bike Insurance", amount: 645.22, date: new Date(2021, 2, 25) },
    { id:'e3',title: "Home Insurance", amount: 94.82, date: new Date(2021, 2, 25) },
    { id:'e4',title: "Health Insurance", amount: 645.22, date: new Date(2021, 2, 25) },
  ];

  const addEexpenseHandler = expense => {
    console.log('In App.js');
    console.log(expense);
  }
  return (
    <div>
      <NewExpense onAddExpense = {addEexpenseHandler} />
      <Card className="expenses">
        <ExpenseItem expense={expenses[0]} />
        <ExpenseItem expense={expenses[1]} />
        <ExpenseItem expense={expenses[2]} />
        <ExpenseItem expense={expenses[3]} />
      </Card>
    </div>
  );
};

export default App;
