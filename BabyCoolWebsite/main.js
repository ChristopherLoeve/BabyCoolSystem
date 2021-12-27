const baseUrl = 'http://localhost:23579/api/Babies'

const app = Vue.createApp({
  data() {
    return {
        babyData: [],
        unitNo: null,
        breath: null,
        crying: null
    }
  },
  methods: {
    async GetBabyData(){
      this.babyData = (await axios.get(baseUrl)).data
    },
    async CreateBabyData(){
      cry = 0
      if (this.crying == "græder") cry = 1

      await axios.post(baseUrl, {id: 0, unitNo: this.unitNo, breath: this.breath, crying: cry})
      this.GetBabyData()
    }
  }
}).mount("#app");
