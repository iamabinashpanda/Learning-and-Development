import ExpenseItem from "./components/ExpenseItem";
function App() {
  const expenses = [
    {title : 'Car Insurance',     amount:64.22,   date:new Date(2021,2,25)},
    {title : 'Bike Insurance',    amount:645.22,  date:new Date(2021,2,25)},
    {title : 'Home Insurance',    amount:94.82,   date:new Date(2021,2,25)},
    {title : 'Health Insurance',  amount:645.22,  date:new Date(2021,2,25)},
  ]
  return (
    <div>
      <ExpenseItem expense={expenses[0]}/>............
      <ExpenseItem expense={expenses[1]}/>
      <ExpenseItem expense={expenses[2]}/>
      <ExpenseItem expense={expenses[3]}/>
    </div>
  );
}

export default App;
