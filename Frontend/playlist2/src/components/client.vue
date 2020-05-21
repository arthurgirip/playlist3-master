<template>
    <div id="client">
        <h1>Client Area</h1>
        <p>
            This is the clients area 
        </p>
        <HelloWorld>
        </HelloWorld>
    </div>
</template>

<script>

import HelloWorld from "../components/HelloWorld.vue";

    export default {
        name: 'Client',
        components:{
            HelloWorld
        },
        data() {
            return {
                
            };
        }
    }
</script>

