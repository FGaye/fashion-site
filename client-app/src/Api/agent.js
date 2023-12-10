import axios from 'axios'

const api = axios.create({
    baseURL: "http://localhost:5272/",
});

export const register = ( ) => api.post('/Account/register');
export const login = ( ) => api.post('/Account/login');