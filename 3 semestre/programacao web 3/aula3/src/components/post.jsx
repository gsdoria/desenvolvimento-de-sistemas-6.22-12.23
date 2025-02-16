import { useState } from "react"
import { post, del } from "../backend/backend"

export default function Post({data, logado, comentarios, func}){

    const [comentario, setComentario] = useState("")

    return (
        <div style={{border: "1px solid gray", marginBottom: 10}}>
            <div style={{
                display: 'flex',
                alignItems: 'center',
                justifyContent: 'center'
            }}>
                <h2>{data.title}</h2>
                <p style={{marginLeft: 10}}>nº: {data.id}</p>
                <h4 style={{marginLeft: 10}}>{data.user}</h4>
                {data.user==logado && <button onClick={()=>{
                    comentarios.map((e,i) =>del(`comentarios/${e.id}`));
                    del(`posts/${data.id}`)
                    func()
                }}>excluir post</button>}

            </div>
            <p>{data.content}</p>


            {logado && (
                <div>
                    <input type="text" placeholder="comentário" onInput={e=>setComentario(e.target.value)}/>
                    <button
                    onClick={async()=>{
                        console.log(data)
                        console.log(logado)
                        console.log(comentario)

                        comentario != "" && post("comentarios", {
                            user: logado,
                            content: comentario,
                            time: new Date(),
                            pid: data.id
                        })

                        func()
                    }}>comentar</button>
                </div>
            )}

            {comentarios.map((e,i)=>{
                
                let d = new Date(e.time)
                let h = d.getHours(), m = d.getMinutes(), s = d.getSeconds()
                let dd = d.getDate(), mm = d.getMonth(), yy = d.getFullYear()
                

                d=`${h}:${m}:${s} - ${dd}/${mm}/${yy}`

                

                return (
                    <div key={i} style={{
                        border: "1px solid gray",
                        justifyContent: 'center',
                        gap: 15,
                        width: '50%',
                        marginLeft: 'auto'
                    }}>
                        <div style={{
                            justifyContent: 'center',
                            display: 'flex',
                            gap: 10,
                        }}>
                            <p>{e.user}</p>
                            <p>{d}</p>
                        </div>
                        <div>
                            <p style={{textAlign: 'left', marginLeft: 10}}>{e.content}</p>
                        </div>
                    </div>

            )})}
            
            
        </div>
    )
}