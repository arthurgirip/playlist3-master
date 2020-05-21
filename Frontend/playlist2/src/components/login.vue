

<template>
   
      <div id="login">
        <h1>
          <svg viewBox="0 -11 512 512" height="25px" width="25px" xmlns="http://www.w3.org/2000/svg"><path d="m474.667969 341.332031h-5.335938v-32c0-29.394531-23.933593-53.332031-53.332031-53.332031s-53.332031 23.9375-53.332031 53.332031v32h-5.335938c-20.585937 0-37.332031 16.746094-37.332031 37.335938v74.664062c0 20.589844 16.746094 37.335938 37.332031 37.335938h117.335938c20.585937 0 37.332031-16.746094 37.332031-37.335938v-74.664062c0-20.589844-16.746094-37.335938-37.332031-37.335938zm-80-32c0-11.753906 9.578125-21.332031 21.332031-21.332031s21.332031 9.578125 21.332031 21.332031v32h-42.664062zm0 0"/><path d="m288 378.667969c0-28.800781 17.644531-53.527344 42.667969-64v-5.335938c0-12.96875 3.132812-25.128906 8.339843-36.160156-16.128906-10.816406-35.5-17.171875-56.339843-17.171875h-181.335938c-55.871093 0-101.332031 45.460938-101.332031 101.332031v74.667969c0 8.832031 7.167969 16 16 16h272zm0 0"/><path d="m298.667969 106.667969c0 58.910156-47.757813 106.664062-106.667969 106.664062s-106.667969-47.753906-106.667969-106.664062c0-58.910157 47.757813-106.667969 106.667969-106.667969s106.667969 47.757812 106.667969 106.667969zm0 0"/></svg>Login
        </h1>
        <form class="login">
          <input type="text" name="name" v-model="input.name" placeholder="Username" />
        <input type="password" name="password" v-model="input.password" placeholder="Password" />
          <p><button type="button" @click="login()">Login</button></p>
          <!-- <button type="button">Register</button> -->
        </form>
        <p>Don't have an account yet? <button @click=register()>Register</button></p>
      </div>


</template>

<script>

    import axios from "axios"
    export default {
        name: 'Login',
        data() {
            return {
                input: {
                    name: "",
                    password: ""
                }
            }
        },
        methods: {
            login() {
                if(this.input.name != "" && this.input.password != "") {
                    // if(this.input.username == this.$parent.mockAdmin.username && this.input.password == this.$parent.mockAdmin.password) {
                    //     this.$emit("authenticated", true);
                    //     this.$router.replace({ name: "admin" });
                    // }
                    // else if(this.input.username == this.$parent.mockClient.username && this.input.password == this.$parent.mockClient.password) {
                    //     this.$emit("authenticated", true);
                    //     this.$router.replace({ name: "client" });
                    // } else {
                    //     console.log("The username and / or password is incorrect");
                    // }
                    axios.post("http://localhost:59098/api/Users/login",this.input).then(
                        success=>{
                            if(success.data)
                            {
                                this.$emit("authenticated", true);
                                this.$router.replace({ name: "client" });
                            }
                            else
                            {
                                alert("Invalid Credentials");
                            }
                        }
                    )
                } else {
                    console.log("A username and password must be present");
                }
            },
            register(){
                this.$router.replace({name: "register"});
            }

        }
    }
</script>

