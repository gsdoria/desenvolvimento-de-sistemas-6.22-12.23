import { useState, useEffect } from 'react'
import {BrowserRouter as Router, Routes, Route, Link} from 'react-router-dom'
import './App.css'
import Home from './pages/home.jsx'
import Postar from './pages/postar.jsx'
import NoPage from './pages/nopage.jsx'

import { get, post, del } from './backend/backend.js'


export default function App() {


    const [cadastro, setCadastro] = useState(true)
    const [login, setLogin] = useState("")
    const [logado, setLogado] = useState(false)
    const [controle, setControle] = useState(true)

    const checkLogin = async l =>await get('users').then(e=>e.some(v=>v.user==l) && setLogado(l))


    return (
        <Router>
            <nav>
                <p>{logado ? `logado como ${logado}` : "não está logado"}</p>
                <ul>
                    <li>
                        <Link to="/">Home</Link>
                    </li>
                    <li>
                        <Link to="/postar">Postar</Link>
                    </li>
                </ul>
            </nav>

            <input type="text" placeholder='login' onInput={e=>setLogin(e.target.value)}/>
            <button onClick={()=>checkLogin(login)}>logar</button>
            <button onClick={()=>setLogado(false)}>sair</button>
            {logado && <button onClick={async()=>setLogado(false) || del(`users/${(await get('users')).filter(e=>e.user==logado)[0].id}`)}>excluir conta</button>}

            <input type="text" placeholder='cadastro' onInput={e=>setCadastro(e.target.value)} 
            maxLength={20}/>

            <button onClick={async ()=>
                !(await get('users').then(e=>e.some(v=>v.user==cadastro))) && ( setLogado(cadastro) || post("users",{user:cadastro}) )
            }>cadastrar</button>



            <Routes>
                <Route index path="/" element={<Home logado={logado}/>}/>
                <Route path="postar" element={<Postar user={logado}/>} />
                <Route path="*" element={<NoPage />} />
            </Routes>
        </Router>
    );
}