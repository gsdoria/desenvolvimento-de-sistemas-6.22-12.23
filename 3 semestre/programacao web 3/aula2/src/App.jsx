import { useState } from 'react'
import './App.css'



var data = [
    { id: 1, ca: "SUV", ma: "Toyota", mo: "Rav4", an: 2008, pr: 53000, },
    { id: 2, ca: "Hatch", ma: "Renault", mo: "Kwid", an: 2016, pr: 42000, },
    { id: 3, ca: "Sedan", ma: "Volkswagem", mo: "Voyage", an: 2010, pr: 35000, },
    { id: 4, ca: "SUV", ma: "Kia", mo: "Sportage", an: 2010, pr: 56000, },
    { id: 5, ca: "Sedan", ma: "Honda", mo: "Civic", an: 2014, pr: 53000, },
    { id: 6, ca: "Coupe", ma: "Honda", mo: "Civic", an: 1995, pr: 42000, },
    { id: 7, ca: "Esportivo", ma: "Volkswagem", mo: "Golf GTI", an: 2017, pr: 35000, },
    { id: 8, ca: "Hatch", ma: "Volkswaem", mo: "Gol", an: 2008, pr: 56000, },
    { id: 9, ca: "Caminhonete", ma: "Toyota", mo: "Hilux", an: 2010, pr: 56000, },
    { id: 10, ca: "Sedan", ma: "Toyota", mo: "Corola", an: 2015, pr: 56000, },
]


function Row(r, key){
    return (<tr key={key}>{ Object.keys(r).map((e,i) => <td key={i}>{r[e]}</td> ) }</tr>)
}



function App() {
    const [texto, setTexto] = useState("")

    let d = data.filter(e=> e.ca.toLowerCase().includes(texto.toLowerCase()) )

    return (
        <div >
            <input type="text" id="a" onChange={e=>setTexto(e.target.value)}/>

            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Categoria</th>
                        <th>Marca</th>
                        <th>Modelo</th>
                        <th>Ano</th>
                        <th>Preço</th>
                    </tr>
                </thead>
                <tbody >
                    {
                        d.length > 0 ?
                        d.map((e,i)=>Row(e, i))
                        :
                        <tr>
                            <td colSpan={5}>Nenhum resultado correspondente</td>
                        </tr>
                    }
                </tbody>
            </table>
        </div>
    )
}

export default App