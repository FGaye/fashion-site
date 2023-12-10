
import { createApp} from 'vue'
import './style.css'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import router from './router'
import App from './App.vue'
const app = createApp(App);
app.use(router)
app.mount('#app')
