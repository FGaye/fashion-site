import {createRouter, createWebHistory} from 'vue-router';


import  HomeView from './views/HomeView.vue';
import  LoginView from './views/LoginView.vue';
import  RegisterView from './views/RegisterView.vue';
import LuxuryView from './views/LuxuryView.vue';
import  SimpleView from './views/SimpleView.vue';
import ClassicView from './views/ClassicView.vue';

const routes = [
    {
        path: '/',
        name: 'home',
        component: HomeView
    },
    {
        path: '/login',
        name: 'login',
        component: LoginView
    },
    {
        path: '/register',
        name: 'register',
        component: RegisterView
    },
    {
        path: '/luxury',
        name: 'luxury',
        component: LuxuryView
    },
    {
        path: '/simple',
        name: 'simple',
        component: SimpleView
    },
    {
        path: '/classic',
        name: 'classic',
        component: ClassicView
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;