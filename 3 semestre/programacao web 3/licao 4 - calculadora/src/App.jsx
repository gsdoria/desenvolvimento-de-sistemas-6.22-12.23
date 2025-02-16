import { useEffect, useState } from 'react'
import {get, post} from './backend/backend'
import { add, clean } from './calcFuncoes'

function App() {
    
    const [texto, setTexto] = useState('')

    // let a;
    // useEffect(()=> async ()=>{
    //     a = await get();

    //     console.log("djsakjdhashdu", a)
    // })
    // console.log(a)

    // console.log(a)

    let a
    let r = async ()=>{
        let a = await get().then(res=>res.json())
        console.log("dsds",a)
        return a
    }
    console.log("sadsada1",a)
    a = r()
    console.log("sadsada2",a)

    return (
        <>
            {/* <p>jikfdsxhiuf</p>
            <input type="text" onInput={e=>setTexto(e.target.value)}/>
            <button onClick={()=>get()}>get</button>
            <button onClick={()=>{post(texto)}}>post</button> */}

            <br />
            <p id="p"></p>
            <br />

            <button onClick={()=>add(1)}>1</button>
            <button onClick={()=>add(2)}>2</button>
            <button onClick={()=>add(3)}>3</button>
            <button onClick={()=>add(4)}>4</button>
            <button onClick={()=>add(5)}>5</button>
            <button onClick={()=>add(6)}>6</button>
            <button onClick={()=>add(7)}>7</button>
            <button onClick={()=>add(8)}>8</button>
            <button onClick={()=>add(9)}>9</button>
            
            <br />
            <button onClick={()=>add("+")}>+</button>
            <button onClick={()=>add("-")}>-</button>
            <button onClick={()=>add("*")}>*</button>
            <button onClick={()=>add("/")}>/</button>

            <button onClick={()=>add("=")}>=</button>

            <br />

            <button onClick={()=>clean()}>C</button>
            <button onClick={()=>console.log(a)}>dkasjd</button>


            


        </>
    )
}

export default App
