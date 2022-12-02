import React, { useEffect, useState } from "react";
import styled from "styled-components";
import axios from 'axios';
import './StyleSheet.css';

import { GetAllPost } from "../components/APIconection/Post";

function Homepage() {
    const [posts, setPosts] = useState([]);

    const fetchPosts = async () => {

        await GetAllPost(setPosts);

        console.log(posts);
    };

    useEffect(() => {
        fetchPosts();
    }, []);


    
    return (
        <ul>
            <li>
                <button name="Hello" onClick={() => { console.log("Hello World") }}>
                    {posts.map((post, index) => (

                        <text>
                            {post.postName}
                        </text>
                        ))
                    }
                    
                </button>
            </li>
        </ul>
    )
}

export default Homepage