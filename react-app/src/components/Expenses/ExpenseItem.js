import "./ExpenseItem.css";
import ExpenseDate from "./ExpenseDate";
import { useState } from "react";
function ExpenseItem(props) {
  //let title = props.expense.title;
  const [title, setTitle] = useState(props.expense.title);
  const clickHandler = () => {
    setTitle('updated');
    console.log(title);
  };

  return (
    <div className="expense-item">
      <ExpenseDate date={props.expense.date} />
      <div className="expense-item__description">
        <h2>{title}</h2>
        <div className="expense-item__price">${props.expense.amount}</div>
      </div>
      <button onClick={clickHandler}>Change Title</button>
    </div>
  );
}
export default ExpenseItem;
