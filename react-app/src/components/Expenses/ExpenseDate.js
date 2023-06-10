import React from "react";
import "./ExpenseDate.css";
function ExpenseDate(props) {
  const month = props.date.toLocaleString("en-US", { month: "long" });
  const year = props.date.getFullYear();
  const day = props.date.toLocaleString("en-US", { day: "2-digit" });
  return (
    // <div className='expense-date'>
    //     <div className='expense-date__month'>{month}</div>
    //     <div className='expense-date__year'>{year}</div>
    //     <div className='expense-date__day'>{day}</div>
    // </div>

    React.createElement(
      "div",
      { className: "expense-date" },
      React.createElement("div", { className: "expense-date__month" }, month),
      React.createElement("div", { className: "expense-date__year" }, year),
      React.createElement("div", { className: "expense-date__day" }, day)
    )
  );
}
export default ExpenseDate;
