import React, {useState, useEffect} from "react";
import { get } from "../backend/backend";
import Post from "../components/post";


export default function Home({logado}) {

    const [listaPosts, setListaPosts] = useState([])
    const [listaComentarios, setListaComentarios] = useState([])
    const [controle, setControle] = useState(true)
    
    useEffect(()=> async()=> controle && ( setListaPosts(await get('posts')) || setListaComentarios(await get('comentarios')) || setControle(false) || console.log("useffct") ) )

    let a = async()=>controle && ( setListaPosts(await get('posts')) || setListaComentarios(await get('comentarios')) || setControle(false) || console.log("useffct") )
    a()

    return (
        <>
            <h2>Home</h2>

            {listaPosts.map((e,i)=><Post key={i} data={e} logado={logado} comentarios={listaComentarios.filter(v=>v.pid == e.id)}

            func={()=>setControle(true)}
            />)}

        </>
    )
}