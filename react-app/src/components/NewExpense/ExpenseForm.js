import React, { useState } from "react";
import './ExpenseForm.css';
const ExpenseForm = (props) => 
{
        const [enteredTitle,setTitle] = useState('');
        const [enteredAmount,setAmount] = useState('');
        const [enteredDate,setDate] = useState('');
        
        // const [userInput,setUserInput] = useState({enteredTitle:'',enteredAmount:'',enteredDate:''});
        
        const titleChangeHandler = (event) => {
            setTitle(event.target.value);
            // setUserInput({...userInput,enteredTitle:event.target.value});
            // setUserInput((prevState) => {return{...userInput,enteredTitle:event.target.value}})
        };
        const amountChangeHandler = (event) => { 
            setAmount(event.target.value);
            // setUserInput({...userInput,enteredAmount:event.target.value});
            // setUserInput((prevState) => {return{...userInput,enteredAmount:event.target.value}})
        };
        const dateChangeHandler = (event) => { 
            setDate(event.target.value);
            // setUserInput({...userInput,enteredDate:event.target.value});
            // setUserInput((prevState) => {return{...userInput,enteredDate:event.target.value}})
        };
        const submitHandler = (event) => {
            event.preventDefault();

            const expenseData = {title:enteredTitle,amount:+enteredAmount,date:new Date(enteredDate)};
            props.onSaveExpenseData(expenseData);
            setTitle('');setAmount('');setDate('');

        };


        

    return <form onSubmit={submitHandler}>
        <div className="new-expense__controls">
        <div className="new-expense__control">
            <label>Title</label>
            <input type='text' value={enteredTitle} onChange={titleChangeHandler}/>
        </div>
        <div className="new-expense__control">
            <label>Amount</label>
            <input type='number' min="0.01" step="0.01" value={enteredAmount} onChange={amountChangeHandler}/>
        </div>
        <div className="new-expense__control">
            <label>Date</label>
            <input type='date' min="2019-01-01" max="2023-12-31" value={enteredDate} onChange={dateChangeHandler}/>
        </div>
        <div className="new-expense__actions">
            <button type="submit" onClick={props.onCancel}>Cancel</button>
            <button type="submit">Add Expense</button>
        </div>
        </div>
    </form>
};
export default ExpenseForm;