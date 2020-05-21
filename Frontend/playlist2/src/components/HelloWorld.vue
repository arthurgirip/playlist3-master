<template>
    <div class="hello">
        <h1>Your user is {{ user }}</h1>
        <input type="text" v-model="input.firstname" placeholder="First Name" />
        <input type="text" v-model="input.lastname" placeholder="Last Name" />
        <button>Send</button>
        <br />
        <br />
        <v-model> {{ response }} </v-model>
    </div>
</template>

<script>
    import axios from "axios";

    export default {
        name: 'HelloWorld',
        data () {
            return {
                user: {
                  id: 0,
                  name:"",
                  email:"",
                  phone:""
                },
                input: {
                    firstname: "",
                    lastname: ""
                },
                response: ""
            }
        },
        mounted() {
          /*
          axios({ method:"GET", "url": "http://localhost:59098/api/Users/1" }).then(result =>{
            this.user = result.data.origin;
            */
           /*
          axios({ method: "GET", "url": "http://localhost:59098/api/Users/1" }).then(result => {
                this.ip = result.data.origin;
            }, error => {
                console.error(error);
                console.log(1);
            });*/
            axios.get('http://localhost:59098/api/Users/1',).then((response)=>{
            this.user=response.data});
            //console.log(this.user)});
        },
        methods: { }
    }
</script>

