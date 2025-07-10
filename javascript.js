const { Builder, By } = require('selenium-webdriver');
const XLSX = require('xlsx');
    const fs = require('fs');

(async function showTableRowTextByXPath() {
  let driver = await new Builder().forBrowser('chrome').build();
    //NETWORK
  try {
    await driver.get('https://xylem1.service-now.com/now/nav/ui/classic/params/target/%24oc_workbench.do%3Fsysparm_redirect%3D%2524oc_groups.do%26sysparm_group_id%3D3e48527e4f3c0200acbe01b28110c701'); // 🔄 Replace with your target URL

    const row = await driver.findElement(By.xpath('/html/body/sn-oc-workbench/div[2]/div/div/div/div/div[1]/div[1]/sn-oc-workbench-escalation-card/div/div/div[2]/div[2]/div[1]/div/div/div[2]/div[1]'));

    const rowTitle = await row.getText();

    let workbook = XLSX.utils.book_new();
    let worksheetData = [
        [rowTitle] 
    ];

    let worksheet = XLSX.utils.aoa_to_sheet(worksheetData);

    XLSX.utils.book_append_sheet(workbook, worksheet, 'Network');
    XLSX.writeFile(workbook, './oncallExcel.xlsm');


  } finally {
    
    await new Promise(res => setTimeout(res, 5000));
    await driver.quit();
  }

    //WEBTEAM
  try {
    await driver.get('https://xylem1.service-now.com/nav_to.do?uri=%2F$oc.do%3Fsysparm_include_view%3Ddaily,weekly,monthly%26sysparm_timezone%3DEurope%2FStockholm%26sysparm_start_date%3D2023-01-23%26sysparm_timeline_enabled%3Dfalse%26sysparm_current_view%3Dweekly%26sysparm_group_id%3D3648127e4f3c0200acbe01b28110c7e7%26sysparm_rotas%3D62c4c688db04f81431ad88d405961993,a79e4640db08f81431ad88d4059619ee,aec4c688db04f81431ad88d405961997%26sysparm_rosters%3Ddedd8e88dbc4f81431ad88d4059619b5,71212600dbccf81431ad88d4059619f9,bddd0e88dbc4f81431ad88d4059619e2,ad8076dcdbc4bcd0c641c7991396190d,758076dcdbc4bcd0c641c79913961967%26sysparm_show_gaps%3Dtrue%26sysparm_show_conflicts%3Dtrue'); // 🔄 Replace with your target URL

    let element = await driver.wait(until.elementLocated(By.xpath('//*[@id="100_cal_item_cmn_rota_member_2dcb4bb61b4f389455556316624bcb9a_cmn_rota_roster_71212600dbccf81431ad88d4059619f9_20230120083000_202301230200003"]/div[3]/div')), 10000);

    let ariaLabel = await element.getAttribute('aria-label');

    const date = new Date();
    const year = date.getFullYear();
    const month = date.toLocaleString('en-US', { month: 'long' });
    const day = date.getDate();

    const todayString = `${year} ${month} ${day}`;

    if (ariaLabel && ariaLabel.includes(todayString)) {
      console.log('Aria-label contains today\'s date:', ariaLabel);

      let workbook;
      let worksheet;

      const filePath = './oncallExcel.xlsm';

      if (fs.existsSync(filePath)) {
        workbook = XLSX.readFile(filePath);
        worksheet = workbook.Sheets['WebTeam'] || XLSX.utils.aoa_to_sheet([[]]);
      } else {
        workbook = XLSX.utils.book_new();
        worksheet = XLSX.utils.aoa_to_sheet([[]]);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'WebTeam');
      }

      worksheet['A1'] = { t: 's', v: ariaLabel };


      XLSX.writeFile(workbook, filePath);

    } else {
      console.log('Aria-label does NOT contain today\'s date.');
    }
      

  } finally {
    await new Promise(res => setTimeout(res, 5000));
    await driver.quit();
  }
})();
