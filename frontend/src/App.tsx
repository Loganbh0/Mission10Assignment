// This file defines the main App component for the React application. 
// It imports the necessary components and styles, 
// and renders the Header and BowlerList components.

import "./App.css";
import Header from "./Header";
import BowlerList from "./BowlerList";

function App() {
  return (
    <>
      <Header />
      <br />
      <br />
      <BowlerList />
    </>
  );
}

export default App;
