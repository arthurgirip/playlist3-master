<template>
    <div id="register">
        <h1 align=center>Register</h1>
        <p>
        <input align=center type="text" name="username" v-model="input.username" placeholder="Username" />
        </p>
        <p>
        <input align=center type="password" name="password" v-model="input.password" placeholder="Password" />
        </p>
        <p>
        <input align=center type="text" name="email" v-model="input.email" placeholder="email" />
        </p>
        <p>
        <input type="text" name="phone" v-model="input.phone" placeholder="phone" />
        </p>
        <div id ="buttons">
            <p>
                <button type="button" v-on:click="complete()">Register</button>
            </p>
        </div>
    </div>
</template>

<script>

    import axios from "axios"
    export default {
        name: 'Register',
        data() {
            return {
                input: {
                    
                    password: "",
                    username: "",
                    email: "",
                    phone: ""
                },
                users: [{id:null,password:"",name:"",email:"",phone:""}]
            }
        },
        
        mounted() {
            axios.get('http://localhost:59098/api/Users',).then((response)=>{
            this.users=response.data
            console.log(this.users[0])});
        },
        methods: {
            //HELP
            insertdb(){
                axios.post('http://localhost:59098/api/Users',this.input).then((response)=>{
                    console.log("success");
                });
            },
            
            complete(){
                for(var i=0;i<this.users.length;i++)
                {
                    if(this.users[i].name==this.input.username || this.users[i].email==this.input.email)
                    {
                        console.log("error");
                        this.$router.replace({name: "register"});
                        return;
                    }
                }
                this.insertdb();
                this.$router.replace({name: "login"});
            }

        }
    }
</script>

