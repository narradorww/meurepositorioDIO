import React from "react"
import ReactDom from "react-dom"
import "./styles.css"

function primeiroJSX() {
    return(
        <div>
            Esta função serve para demonstrar o funcionamento do JSX
            <h1>Soma: {sum(10,35)}</h1>
        </div>
    )
}

function sum(a,b){
    return a + b
}


const App = () => {

return (
    <div className="App">
        {primeiroJSX()}
    </div>
)
}

const rootElement=document.getElementById("root")
ReactDom.render(<App/>,rootElement)