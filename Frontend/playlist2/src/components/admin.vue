<template>
    <div id="admin">
        <h1>Admin Area</h1>
        <p>
            This is the admin area 
        </p>
        <List></List>
    </div>
</template>

<script>

    import List from "../components/list.vue"
    
    export default {
        name: 'Admin',
        components:{
            List
        },
        data() {
            return {};
        }
    }
</script>
