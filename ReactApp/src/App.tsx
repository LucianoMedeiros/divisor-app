import { Suspense } from "react";
import "./App.css";
import reactLogo from "./assets/react.svg";
import { NumberSearchContainer } from "./components/number-search/number-search-container";

function App() {
  return (
    <>
      <div>
        <div>
          <img src={reactLogo} className="logo react" alt="React logo" />
        </div>
        <Suspense fallback={<div>Carregando...</div>}>
          <NumberSearchContainer />
        </Suspense>
      </div>
    </>
  );
}

export default App;
