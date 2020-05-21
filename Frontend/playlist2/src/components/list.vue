<template>
  <ul id="list">
    <li v-for="item in items" :key="item.id">
      {{item}}
      <button @click="deleteUser(item)">Delete</button>
    </li>
  </ul>
</template>

<script>
import axios from "axios";
export default {
  name: "List",
  data() {
    return {

      items: [{ id: null, password: "", name: "", email: "", phone: "" }]
    };
  },
  mounted() {
    axios.get("http://localhost:59098/api/Users").then(response => {
      this.items = response.data;
      console.log("lista apelata");
    });
  },

  methods: {
    deleteUser(user) {
        user.name="t";
      axios.delete(`http://localhost:59098/api/Users/${user.id}`,user).then(response => {
        console.log("deleted");
      });
    }
  }
};
</script>

