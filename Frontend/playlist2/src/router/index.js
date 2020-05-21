import Vue from 'vue'
import VueRouter from 'vue-router'
import LoginComponent from "../components/login.vue"
import AdminComponent from "../components/admin.vue"
import ClientComponent from "../components/client.vue"
import RegisterComponent from "../components/register.vue"

Vue.use(VueRouter)

export default new VueRouter({
    routes: [
        {
            path: '/',
            redirect: {
                name: "login"
            }
        },
        {
            path: "/login",
            name: "login",
            component: LoginComponent
        },
        {
            path: "/admin",
            name: "admin",
            component: AdminComponent
        },
        {
          path: "/client",
          name: "client",
          component: ClientComponent
        },
        {
          path: "/register",
          name: "register",
          component: RegisterComponent
        }
    ]
})